using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixStrangeWay
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] matrix = new int[4,4];
            int swtch = 0;
            int count = 1;



            for (int i = 0; i <= 3; i++)
            {
                if (swtch % 2 == 0)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        
                        matrix[i, j] = count;
                        count++;
                        
                    }
                    swtch++;
                }
            

                    else
                    {
                        for (int k = 3; k >= 0; k--)
                        {
                        
                             matrix[i, k] = count;
                        count++;    
                        }
                    swtch++;
                    }

            }

            for (int l = 0; l < 4; l++)
            {
                for (int m = 0; m < 4; m++)
                {
                    Console.Write (matrix[m, l]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
