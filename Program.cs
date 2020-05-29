using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //LengthOfLongestSubstring("abcabcbb")；
            //LengthOfLongestSubstring("abcabcbb");

            //LengthOfLongestSubstring("abcabcbb");
            string a= "abcdefg";
            Console.WriteLine(a.Substring(1));
            test();
            for (int i = 0; i < 100000; i++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
            
        }
        public static async void test()
        {
           await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Console.WriteLine(i.ToString());
                }
            });

            for (int i = 0; i < 100000; i++)
            {
                Console.Write("-");
            }


        }


        /// <summary>
        /// 请你找出其中不含有重复字符的 最长子串 的长度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //static int LengthOfLongestSubstring(string s)
            
        //{
        //    List<char> ls = new List<char>();
        //    int n = s.Length;
        //    int inMaxLength = 0;
        //    ///fafdsa
        //    for (int i=0;i<n;i++)
        //    {
        //        if (ls.Contains(s[i]))
        //        {
        //            ls.RemoveRange(0, ls.IndexOf(s[i]) + 1);

        //        }
        //        ls.Add(s[i]);
        //        inMaxLength = ls.Count > inMaxLength ? ls.Count : inMaxLength;


        //    }
        //    Console.WriteLine(inMaxLength);
        //    Console.ReadLine();

        //    return inMaxLength;
        //}



    }
}
