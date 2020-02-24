#include "declaration_statement.h"
#include <regex>
#include "../Utils/string_utils.h"
#include <iostream>
#include "statement_parser.h"

const std::regex DECLARARTION_PATTERN{"^([a-zA-Z_$][a-zA-Z_$0-9]*)\\s+([a-zA-Z_$][a-zA-Z_$0-9]*)\\s*(=\\s*(.*))?$"};

DeclarationStatement::DeclarationStatement(string line, string type, string variableName, Statement *value) : Statement(line)
{
    this->type = type;
    this->variableName = variableName;
    this->value = value;
    cout << "[Declaration Statement] " << line << endl;
};

DeclarationStatement *DeclarationStatement::Build(string line)
{
    smatch match;
    regex_search(line, match, DECLARARTION_PATTERN);

    if (match.size() > 0)
    {
        string type = match[1];
        string variableName = match[2];
        string statementValue = match[4];

        Statement *st = StatementParser::ParseStatement(statementValue);

        return new DeclarationStatement(line, type, variableName, st);
    }
    else
    {
        return NULL;
    }
}