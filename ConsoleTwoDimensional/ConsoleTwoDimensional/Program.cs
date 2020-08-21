using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTwoDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array3Db = new char[3, 3] { { 'x', 'y','z' }, 
                                                { 'd', 'o','g' },
                                                { 'a', 'b','c' } 
                                              };
            var res = exist("dog", array3Db);
            Console.WriteLine("dog, exist in the matrix: "+ res);
        }

        private static bool exist(string word, char[,] matrix) {
            string buildword = string.Empty;

            foreach (char t in matrix)
            {
                buildword = buildword + t;
                if (buildword.Length == word.Length)
                {
                    if (buildword.Equals(word))
                    {
                        return true;
                    }
                    else
                    {
                        buildword = string.Empty;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int z = 0; z < matrix.GetLength(0); z++)
                {
                    buildword = buildword + matrix[z, i];
                    if (buildword.Length == word.Length)
                    {
                        if (buildword.Equals(word))
                        {
                            return true;
                        }
                        else
                        {
                            buildword = string.Empty;
                        }
                    }
                }
            }


            return false;
        }
    }
}
