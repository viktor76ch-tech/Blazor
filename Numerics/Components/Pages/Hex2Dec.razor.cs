using Microsoft.AspNetCore.Components;

namespace Numerics.Components.Pages;

public partial class Hex2Dec : ComponentBase
{
    private string hexInput = "";
    private string decimalResult = "";

    protected string HexInput
    {
        get => hexInput;
        set
        {
            hexInput = value;
            ConvertHexToDec();
        }
    }

    protected string DecimalResult => decimalResult;

    private void ConvertHexToDec()
    {
        if (string.IsNullOrWhiteSpace(HexInput))
        {
            decimalResult = "";
            return;
        }

        try
        {
            decimalResult = Convert.ToInt32(HexInput, 16).ToString();
        }
        catch
        {
            decimalResult = "Ошибка: введите корректное шестнадцатеричное число (0-9, A-F)";
        }
    }
}