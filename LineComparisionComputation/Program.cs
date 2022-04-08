using System;
namespace LineComparisionComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparision Computation = new LineComparision(20, 45, 56, 57);
            double Line1 = Computation.CalculateLength();
        }
    
    }
}