﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }

        public string Area()
        {
            return $"Circulo: {Radius * Radius * Math.PI}";
        }
    }
}
