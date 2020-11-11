using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var gg = new List<string>();
            for (int i = 0; i < strings.Length; i++) 
              if (strings[i].Length == 4)
                 gg.Add(strings[i]);
            return gg.ToArray();

        }
    }
}
