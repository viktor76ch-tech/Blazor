using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        int n = 0;
        BigInteger a = 0, b = 1;
        string fibonacciResult = "";
        void FibonacciSeries()
        {
            a = 0; 
            b = 1;
            fibonacciResult = "";
            for (int i = 0; i < n; i++)
            {
                fibonacciResult = fibonacciResult + " " + a;
                BigInteger next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
