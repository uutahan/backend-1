using System;
using System.Collections.Generic;

namespace backend_1
{
    class Program
    {
        static bool isStrInside(string str1, string str2)
        {
            var map1 = new Dictionary<char, int>();
            var map2 = new Dictionary<char, int>();

            HashSet<char> allElems = new HashSet<char>();

            foreach(char c in str1)
            {
                if (map1.ContainsKey(c))
                {
                    map1[c] += 1;
                }

                else
                {
                    map1.Add(c, 1);
                    allElems.Add(c);
                }
            }

            foreach (char c in str2)
            {
                if (map2.ContainsKey(c))
                {
                    map2[c] += 1;
                }

                else
                {
                    map2.Add(c, 1);
                    allElems.Add(c);
                }
            }

            bool map1Bigger = false;
            bool map2Bigger = false;

            foreach(char c in allElems)
            {
                if (map2.ContainsKey(c) && map1.ContainsKey(c))
                {
                    if (map2[c] < map1[c])
                    {
                        map1Bigger = true;
                    }

                    if (map1[c] < map2[c])
                    {
                        map2Bigger = true;
                    }
                }

                else if (map1.ContainsKey(c))
                {
                    map1Bigger = true;
                }

                else if (map2.ContainsKey(c))
                {
                    map2Bigger = true;
                }
            }

            bool justOneMapIncludesAnother = !(map1Bigger == true && map2Bigger == true);

            if(justOneMapIncludesAnother)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool result = isStrInside("aabbd", "baab");

            Console.WriteLine(result);
        }
    }
}
