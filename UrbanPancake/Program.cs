﻿using System;
using UrbanPancake.Library;

namespace UrbanPancake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Thing().Get(19, 23)}");
        }
    }
}
