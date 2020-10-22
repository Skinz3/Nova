﻿using Nova.ByteCode.Codes;
using Nova.ByteCode.Generation;
using Nova.ByteCode.IO;
using Nova.Lexer;
using Nova.IO;
using Nova.Semantics;
using Nova.Statements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nova.ByteCode.Enums;
using Nova.Bytecode.Enums;
using Antlr4.Runtime;

namespace Nova.Members
{
    public class Method : IByteData, IChild
    {
        public Class ParentClass
        {
            get;
            private set;
        }
        private int StartIndex
        {
            get;
            set;
        }
        public int EndIndex
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Id
        {
            get;
            set;
        }
        public ModifiersEnum Modifiers
        {
            get;
            private set;
        }
        public string ReturnType
        {
            get;
            private set;
        }
        public List<Variable> Parameters
        {
            get;
            private set;
        }
        public List<Statement> Statements
        {
            get;
            set;
        }
        private ParserRuleContext Context
        {
            get;
            set;
        }
        public IChild Parent => null;

        public Method(Class parentClass, int methodId, string methodName, ModifiersEnum modifiers, string returnType,
            List<Variable> parameters, int startIndex, int endIndex, ParserRuleContext context)
        {
            this.Id = methodId;
            this.ParentClass = parentClass;
            this.Name = methodName;
            this.Modifiers = modifiers;
            this.ReturnType = returnType;
            this.Parameters = parameters;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Context = context;
            this.Statements = new List<Statement>();
        }
        public bool IsMainPointEntry()
        {
            return Modifiers == ModifiersEnum.@public && Name == Constants.MainPointEntryMethodName && Parameters.Count == 0;
        }
        public Method(Class parentClass)
        {
            this.ParentClass = parentClass;
            this.Statements = new List<Statement>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(ParentClass + "." + Name);
            sb.Append("(");
            sb.Append(string.Join(",", Parameters.Select(x => x.ToString())));
            sb.Append(")");

            return sb.ToString();
        }

        public IByteElement GetByteElement(ClassesContainer container, IByteElement parent)
        {
            ByteMethod result = new ByteMethod(this.Name, Modifiers, Parameters.Count, (ByteClass)parent);

            foreach (var parameter in Parameters)
            {
                result.ByteBlock.SymbolTable.Bind(parameter.Name, parameter.Type);
            }
            foreach (var statement in Statements)
            {
                statement.GenerateBytecode(container, result.ByteBlock);
            }

            if (result.ByteBlock.Instructions.Count == 0 || (!(result.ByteBlock.Instructions.Last() is ReturnCode)))
            {
                result.ByteBlock.Instructions.Add(new ReturnCode());
            }


            return result;

        }

        public IEnumerable<SemanticalError> ValidateSemantics(ClassesContainer container)
        {
            SemanticsValidator validator = new SemanticsValidator(ParentClass, container);

            if (ParentClass.Type == ContainerType.@struct && IsMainPointEntry())
            {
                validator.AddError("Main point entry cannot be member of struct \"" + ParentClass.ClassName + "\"", Context);
            }
            foreach (var param in Parameters)
            {
                validator.DeclareVariable(param.Name, param.Type);
            }

            foreach (var statement in this.Statements)
            {
                statement.ValidateSemantics(validator);
            }

            return validator.GetErrors();
        }
    }
}
