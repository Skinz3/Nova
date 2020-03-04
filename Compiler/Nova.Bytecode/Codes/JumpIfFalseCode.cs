﻿using Nova.ByteCode.Runtime;
using Nova.Utils.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.ByteCode.Codes
{
    public class JumpIfFalseCode : ICode
    {
        public int OpId => 5;

        public int targetIndex;

        public JumpIfFalseCode(int index)
        {
            this.targetIndex = index;
        }

        public void Compute(RuntimeContext context,  object[] locals, ref int index)
        {
            if ((int)context.PopStack() == 0)
            {
                index = this.targetIndex;
            }
            else
            {
                index++;
            }
        }
        public override string ToString()
        {
            return "(" + OpId + ") " +  "JumpIfFalse " + targetIndex;
        }

        public void Serialize(CppBinaryWriter writer)
        {
            writer.Write(targetIndex);
        }
        public int GetSize()
        {
            return 1;
        }
    }
}
