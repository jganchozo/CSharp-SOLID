﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class AreaCalculator
    {
        public string Area(List<IShape> shapes)
        {
            string area = string.Empty;

            foreach (var shape in shapes)
            {
                area += shape.Area();
                area += Environment.NewLine;
            }

            return area;
        }
    }
}