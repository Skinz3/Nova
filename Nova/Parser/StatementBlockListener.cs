﻿using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Nova.Lexer;
using Nova.Members;
using Nova.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NovaParser;

namespace Nova.Parser
{
    public class StatementBlockListener : NovaParserBaseListener
    {
        private IStatementBlock Block
        {
            get;
            set;
        }

        public StatementBlockListener(IStatementBlock block)
        {
            this.Block = block;
        }
        public override void EnterLocalVariableDeclaration([NotNull] NovaParser.LocalVariableDeclarationContext context)
        {
            VariableDeclaratorContext declarator = context.variableDeclarator();
            string type = context.typeType().GetChild(0).GetText();
            string name = declarator.variableDeclaratorId().GetText();

            Variable variable = new Variable(type, name);

            ExpressionNode value = new ExpressionNode(Block); // should not be block but the statement.

            VariableInitializerContext initializer = declarator.variableInitializer();

            if (initializer != null)
            {
                ExpressionContext expressionContext = initializer.expression();

                ExpressionListener listener = new ExpressionListener(Block); // same here

                ParseTreeWalker.Default.Walk(listener, context);

                value = listener.GetResult();
            }

            Block.Statements.Add(new DeclarationStatement(Block, variable, value, context));
        }

        public override void EnterBlock([NotNull] NovaParser.BlockContext context)
        {
            base.EnterBlock(context);
        }
    }

}