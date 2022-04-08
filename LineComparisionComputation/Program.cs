using System;
namespace LineComparisionComputation
{
    class Program
    {
       public static void Main(string[] args)
        {
            LineComparision Line1 = new LineComparision(2, 5, 7, 8);
            double l1= Line1.CalculateLength();
            LineComparision Line2 = new LineComparision(6, 8, 3, 9);
            double l2= Line2.CalculateLength();
            if (l1.CompareTo(l2) == 0)
            { 
                Console.WriteLine("Both Lines Lengths Are Equal");
            }
            else if (l2.CompareTo(l1) > 0)
            {
                Console.WriteLine("Both Lines Length Are Not Equal");
            }

        }

    }
}