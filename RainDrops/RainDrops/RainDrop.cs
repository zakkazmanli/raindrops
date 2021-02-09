using System;
using System.Collections.Generic;
using System.Text;

namespace RainDrops
{
    public class RainDrop
    {
        public string ConvertNumToRainDropString(int num)
        {
            string output = "";

            if (num % 3 == 0) { output += "Pling"; }
            if (num % 5 == 0) { output += "Plang"; }
            if (num % 7 == 0) { output += "Plong"; }

            if (string.IsNullOrEmpty(output)) { output = num.ToString(); }
            return output;
        }
    }
}
