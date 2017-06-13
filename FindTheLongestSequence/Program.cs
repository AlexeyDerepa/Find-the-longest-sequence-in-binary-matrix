using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr2 = {
                              {0,0,1,0,1,0,0,1,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {1,1,0,0,1,1,1,0,0,1},
                              {1,0,0,0,1,1,0,0,0,1},
                              {1,1,0,0,0,1,1,0,0,1},
                              {0,1,0,0,1,0,1,0,0,0},
                              {1,0,0,0,1,1,1,0,0,1},
                              {1,1,1,1,1,1,1,1,0,1},
                              {1,1,0,0,1,1,1,0,0,1},
                              {0,1,1,1,0,1,1,1,1,0}
                          };

            ElementaryProcessingOfBinaryMatrix pm = new ElementaryProcessingOfBinaryMatrix();
            pm.SetArray(arr2);
            Console.WriteLine(pm.Processing());
            Console.WriteLine();


            SophisticatedProcessingOfBinaryMatrix pr_3 = new SophisticatedProcessingOfBinaryMatrix();
            pr_3.SetArray(arr2);
            Console.WriteLine(pr_3.Processing());
            string output = pr_3.GetCurrentLongestSequence.ToString();
            Console.WriteLine(output); 


            Console.Read();
        }


    }
}
