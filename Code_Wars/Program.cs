using System;
using System.Collections.Generic;




class Program
{

    static void Main(string[] args)
    {
        string s = "Sasha  Sa sha sha qwe qwe iop[ 'ghjk rtyu []sd []sd iop[ []sd rtyu rtyu 'ghjk m b";
        List<string> masString = new List<string>();
        masString = library.Top3(s);

        for (int i = 0; i < masString.Count; i++)
        {
            Console.Write(masString[i] + " ");
        }

    }
}
