﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresRefEOut
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triple1(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
