﻿using Nova.ByteCode.Codes;
using Nova.ByteCode.Generation;
using Nova.Lexer;
using Nova.IO;
using Nova.Members;
using Nova.Semantics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace Nova.Statements
{
    public class DeclarationStatement : Statement
    {
        public Variable Variable
        {
            get;
            set;
        }
        public ExpressionNode Value
        {
            get;
            set;
        }
        public DeclarationStatement(IChild parent, ParserRuleContext context) : base(parent, context)
        {
            
        }


        public override void GenerateBytecode(ClassesContainer container, ByteBlock context)
        {
            List<ICode> results = new List<ICode>();

            int variableId = context.SymbolTable.Bind(Variable.Name, Variable.RawType);

            Value.GenerateBytecode(container, context);
            context.Instructions.Add(new StoreCode(variableId));
        }

        public override void ValidateSemantics(SemanticsValidator validator)
        {
            Value.ValidateSemantics(validator);
            validator.DeclareVariable(Variable);

        }

        public override void ValidateTypes(SemanticsValidator validator)
        {
            Variable.ValidateTypes(validator);
        }
    }
}
