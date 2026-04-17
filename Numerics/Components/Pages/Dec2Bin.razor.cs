using Microsoft.AspNetCore.Components;

namespace Numerics.Components.Pages;

public partial class Dec2Bin : ComponentBase
{
    private int decimalInput;
    private string binaryResult = "";

    protected int DecimalInput
    {
        get => decimalInput;
        set
        {
            decimalInput = value;
            ConvertDecToBin();
        }
    }

    protected string BinaryResult => binaryResult;

    private void ConvertDecToBin()
    {
        if (DecimalInput >= 0)
        {
            binaryResult = Convert.ToString(DecimalInput, 2);
        }
        else
        {
            binaryResult = "Ошибка: введите неотрицательное число";
        }
    }
}