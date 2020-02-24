#ifndef BINWRITER
#define BINWRITER

#include <string>
#include <iostream>
#include <fstream>
#include "../../Core/logger.h"

using namespace std;

class BinaryWriter
{
private:
    ofstream stream;

public:
    BinaryWriter(string filePath)
    {
        stream.open(filePath.c_str(), ios::binary);
        if (!stream.is_open())
        {
           Logger::OnError(ErrorType::IO,"Cannot append file : " + filePath);
        }
    }
    template <typename T>
    void Write(T &value)
    {
        stream.write((const char *)&value, sizeof(value));
    }

    void WriteString(string str)
    {
        str += '\0';
        char *text = (char *)(str.c_str());
        unsigned long size = str.size();
        stream.write((const char *)text, size);
    }
    void Close()
    {
        stream.close();
    }
};


#endif // BINWRITER