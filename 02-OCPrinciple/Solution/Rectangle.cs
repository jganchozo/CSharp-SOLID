﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Rectangle : IShape
    {
        public double With { get; set; }
        public double Height { get; set; }

        public string Area()
        {
            return $"Rectangulo: {With * Height}";
        }
    }
}
