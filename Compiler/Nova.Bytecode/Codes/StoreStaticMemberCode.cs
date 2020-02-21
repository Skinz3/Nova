﻿using Nova.ByteCode.Codes;
using Nova.ByteCode.Runtime;
using Nova.Utils.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.Bytecode.Codes
{
    public class StoreStaticMemberCode : ICode
    {
        public int TypeId => 15;

        private string fieldName;

        public StoreStaticMemberCode(string fieldName)
        {
            this.fieldName = fieldName;
        }

        public void Compute(RuntimeContext context, ref object[] locals, ref int index)
        {
            object value = context.PopStack();
            context.SetStaticMemberVariable(fieldName, value);
            index++;
        }

        public void Serialize(CppBinaryWriter writer)
        {
            writer.Write(fieldName);
        }
    }
}