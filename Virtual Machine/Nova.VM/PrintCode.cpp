#include "PrintCode.h"

PrintCode::PrintCode(std::string val)
{
	this->value = val;
}

void PrintCode::Compute(RuntimeContext& context, int& index)
{
	std::cout << this->value << std::endl;
	index++;
}