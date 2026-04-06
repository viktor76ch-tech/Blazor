using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Blazor.Components.Pages
{
    public partial class Power
    {
        double num;
        double pow;
        double result;

        void Calculate()
        {
            result = Math.Pow(num, pow);
        }
        
    }
}
