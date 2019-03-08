using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusProblem
{
    public class Josephus
    {
        public static void Main()
        {
            JosephFunctions ob1 = new JosephFunctions();
            Console.WriteLine("Enter the number of person in the game");
            int n = Convert.ToInt32(Console.ReadLine());
            // if number k which indicates that k-1 persons are skipped and kth person is killed in circle.
            Console.WriteLine("Enter the number of persons to be skipped");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The person who survived is " + ob1.josephus(n, k));
            Console.ReadKey();

        }
    }
}


