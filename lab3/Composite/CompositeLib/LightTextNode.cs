﻿using CompositeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeLib
{
    public class LightTextNode : LightNode
    {
        public string text { get; set; }
        public LightTextNode(string text)
        {
            this.text = text;
        }

        public override void OutterLightHTML()
        {
            Console.WriteLine(text);
        }
    }
}