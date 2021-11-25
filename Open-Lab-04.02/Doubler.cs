using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string a = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                string b = Convert.ToString(original[i]) + original[i];
                a = a + b;
            }
            return a;

        }
    }
}
