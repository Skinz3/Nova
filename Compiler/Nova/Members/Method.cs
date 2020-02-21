﻿using Nova.ByteCode.Codes;
using Nova.ByteCode.Generation;
using Nova.ByteCode.IO;
using Nova.Enums;
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

namespace Nova.Members
{
    public class Method : IParentBlock, IByteData
    {
        public const string METHOD_PATTERN = @"^(public|private)\s+(static)?\s*([a-zA-Z_$][a-zA-Z_$0-9]*)\s+([a-zA-Z_$][a-zA-Z_$0-9]*)\((.*?)\)";

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
        private int EndIndex
        {
            get;
            set;
        }
        public string Name
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
            private set;
        }

        public IParentBlock Parent => null;

        public Method(Class parentClass, string methodName, ModifiersEnum modifiers, string returnType, List<Variable> parameters, int startIndex, int endIndex)
        {
            this.ParentClass = parentClass;
            this.Name = methodName;
            this.Modifiers = modifiers;
            this.ReturnType = returnType;
            this.Parameters = parameters;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Statements = new List<Statement>();
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

        public bool BuildStatements()
        {
            this.Statements = Parser.BuildStatementBlock(this, StartIndex, EndIndex, this.ParentClass.File.Lines);
            return true;
        }


        public IByteElement GetByteElement(IByteElement parent)
        {
            ByteMethod result = new ByteMethod(this.Name, (ByteClass)parent);

            foreach (var parameter in Parameters)
            {
                result.Meta.BindVariable(parameter.Name);
            }
            foreach (var statement in Statements)
            {
                statement.GenerateBytecode(result.Meta);
            }


            return result;

        }

        public IEnumerable<SemanticalError> ValidateSemantics(ClassesContainer container)
        {
            SemanticsValidator validator = new SemanticsValidator(container);

            foreach (var statement in this.Statements)
            {
                statement.ValidateSemantics(validator);
            }

            return validator.GetErrors();
        }
    }
}