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
    public class ReturnStatement : Statement
    {
        public const string REGEX = @"^return\s*(.+)?$";

        private ExpressionNode Value
        {
            get;
            set;
        }
        public ReturnStatement(IChild parent, ExpressionNode value, ParserRuleContext context) : base(parent, context)
        {
            this.Value = value;
        }
   

        public override void GenerateBytecode(ClassesContainer container, ByteBlock context)
        {
            if (!Value.Empty)
            {
                Value.GenerateBytecode(container, context);
            }
            context.Instructions.Add(new ReturnCode());
        }

        public override void ValidateSemantics(SemanticsValidator validator)
        {
            Value.ValidateSemantics(validator);
        }
    }
}
