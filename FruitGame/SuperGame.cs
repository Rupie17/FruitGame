﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitGame
{
    class SuperGame
    {
        public static void UpdatePosition(string key, out int xChange, out int yChange)
        {
            xChange = 0;
            yChange = 0;
        }

        public static char UpdateCursor(string key)
        {
            return '<';
        }

        public static int KeepInBounds(int dimension, int max)
        {
            return dimension;
        }

        public static bool DidScore(int x1, int y1, int x2, int y2)
        {
            return false;
        }
    }
}
