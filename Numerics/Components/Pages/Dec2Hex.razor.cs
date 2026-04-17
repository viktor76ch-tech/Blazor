using Microsoft.AspNetCore.Components;

namespace Numerics.Components.Pages;

public partial class Dec2Hex : ComponentBase
{
    private int decimalInput;
    private string hexResult = "";

    protected int DecimalInput
    {
        get => decimalInput;
        set
        {
            decimalInput = value;
            ConvertDecToHex();
        }
    }

    protected string HexResult => hexResult;

    private void ConvertDecToHex()
    {
        if (DecimalInput >= 0)
        {
            hexResult = Convert.ToString(DecimalInput, 16).ToUpper();
        }
        else
        {
            hexResult = "Ошибка: введите неотрицательное число";
        }
    }
}