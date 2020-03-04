#include <iostream>
#include "NovFile.h"
#include "Exec.h"
#include "Logger.h"

int main(int argc, char* argv[])
{
	if (argc != 2)
	{
		Logger::Log("You need to specify 1 .nov file");
		return 0;
	}
	std::string fileName = argv[1];

	NovFile file(fileName);
	
	if (!file.Deserialize())
	{
		return EXIT_FAILURE;
	}

	file.Print();

	Exec::Run(file);

	return EXIT_SUCCESS;
}