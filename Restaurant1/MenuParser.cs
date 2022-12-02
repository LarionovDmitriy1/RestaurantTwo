using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant1
{
    public static class MenuParser
    {

        public static void Parser(string selected, List<string> menu)
        {
            List<string> strings = new List<string>();
            List<string> menu2 = new List<string>();

            foreach (var item in menu)
            {
                string item2 = item.ToLower();
                menu2.Add(item2);
            }
            foreach (var item in menu2)
            {

                if (selected.Contains(item))
                {
                    strings.Add(item + ' ');
                }
            }
            for (int i = 0; i < strings.Count; i++)
            {
                string s = strings[i];
                s = Char.ToUpper(s[0]) + s.Remove(0, 1);
                strings[i] = s;
                Console.Write(strings[i]);
            }

        }
    }
}
