using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            
            string a = "";
            
            for(int i = 0; i < orig.Length; i++)
            {
                for (int q = 0; q < n; q++)
                {
                    a = a + orig[i];
                }
            }
            return a;
            
        }
    }
}
