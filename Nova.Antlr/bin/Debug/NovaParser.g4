
parser grammar NovaParser;

options { tokenVocab=NovaLexer; }

compilationUnit
    : importDeclaration* typeDeclaration* EOF
    ;

importDeclaration
    : USING LT IDENTIFIER GT 
    ;

typeDeclaration
    : (classDeclaration | structDeclaration)
    | SEMI
    ;

classDeclaration
    : CLASS IDENTIFIER
      classBody
    ;

structDeclaration
    : STRUCT IDENTIFIER
      classBody
    ;

classBody
    : '{' (memberDeclaration)* '}'
    ;

memberDeclaration
    : modifier methodDeclaration
    | modifier fieldDeclaration
    | constructorDeclaration
    ;

modifier
    : classModifier
    ;

classModifier 
    : PUBLIC
    | PRIVATE
    ;

fieldDeclaration
    : typeType variableDeclarator 
    ;

variableDeclarator
    : variableDeclaratorId (ASSIGN variableInitializer)?
    ;

variableInitializer
    : expression
    ;   

variableDeclaratorId
    : IDENTIFIER 
    ;

typeType
    : (IDENTIFIER | primitiveType) 
    ;

primitiveType
    : BOOLEAN
    | CHAR
    | BYTE
    | SHORT
    | INT
    | STRING
    | LONG
    | FLOAT
    | DOUBLE
    ;


expression
    : methodCall #metCall
    | expression bop='.' methodCall #methodAccessor
    | expression bop='.' IDENTIFIER #fieldAccessor
    | nativeCall #ntvCall
    | constructorCall #ctorCall
    | primary  #primaryValue 
    | prefix=('+'|'-') expression #unaryExpr
    | left=expression bop=('*'|'/') right=expression #binaryExpr
    | left=expression bop=('+'|'-') right=expression #binaryExpr
    | left=expression ('<' '<' | '>' '>' '>' | '>' '>') right=expression #binaryExpr
    | left=expression bop=('<=' | '>=' | '>' | '<') right=expression #binaryExpr
    | left=expression bop=('==' | '!=') right=expression #binaryExpr
    | left=expression bop='&&' right=expression #binaryExpr
    | left=expression bop='||' right=expression #binaryExpr

    ;

methodDeclaration
    : typeTypeOrUnit IDENTIFIER formalParameters (LBRACK RBRACK)*
      methodBody
    ;

typeTypeOrUnit
    : typeType
    | UNIT
    ;


formalParameters
    : '(' formalParameterList? ')'
    ;

formalParameterList
    : formalParameter (',' formalParameter)* (',' lastFormalParameter)?
    | lastFormalParameter
    ;

formalParameter
    : typeType variableDeclaratorId
    ;

lastFormalParameter
    : typeType variableDeclaratorId
    ;

constructorDeclaration
    : '->' IDENTIFIER formalParameters constructorBody=block
    ;

methodBody
    : block
    ;

block
    : '{' statement* '}'
    ;

localVariableDeclaration
    : typeType variableDeclarator
    ;

statement
    : blockLabel=block
    | localVariableDeclaration 
    | ifStatement
    | forStatement
    | whileStatement
    | returnStatement
    | assignationStatement
    | statementExpression

    ;
whileStatement:
    WHILE parExpression statement
    ;   
returnStatement
    :  RETURN expression? 
    ;

assignationStatement
    : <assoc=right> left=expression '=' right=expression
    ;

statementExpression
    : expression 
    ;
ifStatement
    :IF parExpression ifSt=statement (ELSE elseSt=statement)?
    ;

forStatement
    : 
    FOR '(' forControl ')' statement
    ;

parExpression
    : '(' expression ')'
    ;

forControl
    : forInit=statement ';' forCond=expression ';' forUpdate=assignationStatement
    ;


expressionList
    : expression (COMMA expression)*
    ;

primary
    : '(' expression ')' # primaryExpr
    | literal # primarylit
    | IDENTIFIER # litIdent
    ;

literal
    : integerLiteral # int
    | floatLiteral # float
    | CHAR_LITERAL # char
    | STRING_LITERAL # string
    | BOOL_LITERAL # bool
    | NULL_LITERAL # null
    ;

integerLiteral
    : DECIMAL_LITERAL
    | HEX_LITERAL
    | OCT_LITERAL
    | BINARY_LITERAL
    ;

floatLiteral
    : FLOAT_LITERAL
    | HEX_FLOAT_LITERAL
    ;

methodCall
    : IDENTIFIER '(' expressionList? ')'
    ;

constructorCall
    : NEW creator
    ;

nativeCall
    : '~' IDENTIFIER '(' expressionList? ')'
    ;

creator
    : createdName (classCreatorRest)
    ;

createdName
    : IDENTIFIER 
    ;

classCreatorRest
    : arguments 
    ;

arguments
    : '(' expressionList? ')'
    ;
