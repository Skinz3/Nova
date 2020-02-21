﻿using Nova.ByteCode.Codes;
using Nova.ByteCode.Generation;
using Nova.Utils.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.ByteCode.IO
{
    public class ByteMethod : IByteElement
    {
        public string Name
        {
            get;
            set;
        }
        public ByteBlockMetadata Meta
        {
            get;
            set;
        }
        public ByteClass ParentClass
        {
            get;
            set;
        }
        public ByteMethod(string name, ByteClass parentClass)
        {
            this.Name = name;
            this.Meta = new ByteBlockMetadata();
            this.ParentClass = parentClass;
        }
     
        public void Serialize(CppBinaryWriter writer)
        {
            writer.Write(Name);
            Meta.Serialize(writer);
        }
    }
}