#include "Exec.h"
#include "OpCodes.h"
#include "Logger.h"
#include "OperatorsEnum.h"
#include "RuntimeStruct.h"

#include "Call.h"

template<class... Ts> struct overloaded : Ts... { using Ts::operator()...; };
template<class... Ts> overloaded(Ts...)->overloaded<Ts...>;

void Exec::Execute(RuntimeContext* context, ByteMethod* mainMethod)
{


	int ip = 0;

	std::vector<RuntimeContext::RuntimeElement> locales(mainMethod->block->localesCount);


	std::vector<int> ins = mainMethod->block->instructions;

	Call call(mainMethod, nullptr, -1, locales);

	context->callStack.push_back(&call);

	while (ip < ins.size())
	{
		switch (ins[ip])
		{
		case OpCodes::Add:
			context->PushStack(std::get<int>(context->PopStack()) + std::get<int>(context->PopStack()));
			ip++;
			break;
		case OpCodes::Sub:
		{
			int val1 = std::get<int>(context->PopStack());
			int val2 = std::get<int>(context->PopStack());
			context->PushStack(val2 - val1);
			ip++;
			break;
		}
		case OpCodes::Mul:
			context->PushStack(std::get<int>(context->PopStack()) * std::get<int>(context->PopStack()));
			ip++;
			break;
		case OpCodes::PushInt:
			context->PushStack(ins[++ip]);
			ip++;
			break;
		case OpCodes::Store:
			locales[ins[++ip]] = context->PopStack();
			ip++;
			break;
		case OpCodes::Load:
		{
			int id = ins[++ip];
			context->PushStack(locales[id]);
			ip++;
			break;
		}
		case OpCodes::Printl:
		{
			RuntimeContext::RuntimeElement ele = context->PopStack();

			std::visit(overloaded
				{
						[](Null* arg) { std::cout << "null" << std::endl; },
						[](bool arg) { std::cout << (arg ? "true" : "false") << std::endl; },
						[](RuntimeStruct* arg) { std::cout << "{" << arg->typeClass->name << "}" << std::endl; },
						[](int arg) { std::cout << arg << std::endl; },
						[](std::string* arg) { std::cout << *arg << std::endl; },

				}, ele);

			ip++;
			break;
		}
		case OpCodes::PushConst:
			context->PushStack(context->GetConstant(ins[++ip]));
			ip++;
			break;
		case OpCodes::Jump:
			ip = ins[++ip];
			break;
		case OpCodes::JumpIfFalse:

			if (std::get<bool>(context->PopStack()) == false)
			{
				ip = ins[++ip];
			}
			else
			{
				ip += 2;
			}
			break;
		case OpCodes::Comparaison:
		{
			int cmpType = ins[++ip];

			bool result = false;

			int val2 = std::get<int>(context->PopStack());
			int val1 = std::get<int>(context->PopStack());

			switch (cmpType)
			{
			case OperatorsEnum::Inferior:
				result = val1 < val2;
				break;
			case OperatorsEnum::Equals:
				result = val1 == val2;
				break;
			}

			context->PushStack(result);
			ip++;
			break;
		}

		case OpCodes::StructCreate:
		{
			context->PushStack(context->CreateStruct(ins[++ip]));
			ip++;
			break;
		}
		case OpCodes::CtorCall:
		{
			int parametersCount = ins[++ip];
			int methodId = ins[++ip];
			RuntimeStruct* obj = std::get<RuntimeStruct*>(context->StackMinus(parametersCount));
			context->structsStack.push_back(obj);
			ByteMethod* method = obj->typeClass->methods[methodId];
			CallMethod(context, method, &ip, &ins, &locales);
			break;
		}
		case OpCodes::StructPushCurrent:
		{
			context->PushStack(context->GetCurrentStruct());
			ip++;
			break;
		}
		case OpCodes::StructLoadMember:
		{
			RuntimeContext::RuntimeElement stElement = context->PopStack();

			if (std::holds_alternative<Null*>(stElement))
			{
				ip = ins.size();
				Logger::Error("Null reference exception."); /* Todo : handle this kind of errors. */
				return;
			}
			RuntimeStruct* st = std::get<RuntimeStruct*>(stElement);
			int fieldId = ins[++ip];
			RuntimeContext::RuntimeElement member = st->Get(fieldId);
			context->PushStack(member);
			ip++;
			break;
		}
		case OpCodes::StructStoreMember:
		{
			RuntimeStruct* st = std::get<RuntimeStruct*>(context->PopStack());
			RuntimeContext::RuntimeElement ele = context->PopStack();
			st->Set(ins[++ip], ele);
			ip++;
			break;
		}
		case OpCodes::StructCallMethod: 
		{
			RuntimeStruct* st = std::get<RuntimeStruct*>(context->PopStack());
			context->structsStack.push_back(st);
			ByteMethod* method = st->typeClass->methods[ins[++ip]];
			CallMethod(context, method, &ip, &ins, &locales);
			break;
		}
		case OpCodes::MethodCall:
		{
			int classId = ins[++ip];
			int methodId = ins[++ip];
			ByteMethod* method = context->novFile->byteClasses[classId]->methods[methodId];
			CallMethod(context, method, &ip, &ins, &locales);
			break;
		}
		case OpCodes::StoreGlobal:
		{
			int classId = ins[++ip];
			int fieldId = ins[++ip];
			context->Set(classId, fieldId, context->PopStack());
			ip++;
			break;
		}
		case OpCodes::LoadGlobal:
		{
			int classId = ins[++ip];
			int fieldId = ins[++ip];
			context->PushStack(context->Get(classId, fieldId));
			ip++;
			break;
		}
		case OpCodes::PushNull:
		{
			context->PushStack(RuntimeContext::NULL_VALUE);
			ip++;
			break;
		}
		case OpCodes::Return:
		{
			if (context->callStack.size() == 1) 
			{
				return;
			}

			Call* lastCall = context->callStack[context->callStack.size() - 1];

			if (lastCall->method->parent->type == ContainerType::Struct)
			{
				context->structsStack.resize(context->structsStack.size() - 1);
			}
			ip = lastCall->returnIp;
			ins = lastCall->previousMethod->block->instructions;
			locales = lastCall->previousLocales;
			locales.resize(lastCall->previousMethod->block->localesCount);

			delete lastCall;
			context->callStack.resize(context->callStack.size() - 1);
			break;
		}
		default:
			Logger::Error("Unhandled op code: " + std::to_string(ins[ip]));
			return;
		}
	}
}

void Exec::CallMethod(RuntimeContext* context, ByteMethod* targetMethod, int* ip, std::vector<int>* ins, std::vector<RuntimeContext::RuntimeElement>* locales)
{
	ByteMethod* executingMethod = context->callStack[context->callStack.size() - 1]->method;

	Call* methodCall = new Call(targetMethod, executingMethod, (*ip) + 1, *locales); // how to optimize this...

	context->callStack.push_back(methodCall);

	locales->resize(targetMethod->block->localesCount);

	for (int i = 0; i < locales->size(); i++)
	{
		locales->at(i) = context->PopStack();
	}

	*ip = 0;
	*ins = targetMethod->block->instructions;
}


