﻿using Nova.Utils.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.ByteCode.IO
{
    public class ByteClass : IByteElement
    {
        public string Name
        {
            get;
            private set;
        }
        public Dictionary<string, ByteMethod> Methods
        {
            get;
            set;
        }
        public Dictionary<string, ByteStaticField> Fields
        {
            get;
            set;
        }

        public ByteClass(string name)
        {
            this.Name = name;
            this.Methods = new Dictionary<string, ByteMethod>();
            this.Fields = new Dictionary<string, ByteStaticField>();
        }

    

        public void Serialize(CppBinaryWriter writer)
        {
            writer.Write(Name);

            writer.Write(Methods.Count);

            foreach (var method in Methods)
            {
                writer.Write(method.Key);
                method.Value.Serialize(writer);
            }

            writer.Write(Fields.Count);

            foreach (var field in Fields)
            {
                writer.Write(field.Key);
                field.Value.Serialize(writer);
            }
        }
    }
}