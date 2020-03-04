#pragma once
#include "BinaryReader.h"
#include <vector>
class ByteBlock
{
public:
	void Deserialize(BinaryReader& reader);

private:
	std::vector<int> instructions;
};

