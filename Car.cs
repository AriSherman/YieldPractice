﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldCollectionPractice
{
    internal class Car
    {
        public int ModelYear { get; set; }
        public string Maker { get; set; }


        public override string ToString()
        {
            return ModelYear + " " + Maker;
        }
    }
}
