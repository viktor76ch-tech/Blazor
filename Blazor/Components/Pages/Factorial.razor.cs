using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Factorial
    {
        int n;
        BigInteger factorial;
        void Calculate()
        {
            factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
        }
    }
}
