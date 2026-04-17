using Microsoft.AspNetCore.Components;

namespace Numerics.Components.Pages;

public partial class Hex2Bin : ComponentBase
{
    private string hexInput = "";
    private string binaryResult = "";

    protected string HexInput
    {
        get => hexInput;
        set
        {
            hexInput = value;
            ConvertHexToBin();
        }
    }

    protected string BinaryResult => binaryResult;

    private void ConvertHexToBin()
    {
        if (string.IsNullOrWhiteSpace(HexInput))
        {
            binaryResult = "";
            return;
        }

        try
        {
            int decimalValue = Convert.ToInt32(HexInput, 16);
            binaryResult = Convert.ToString(decimalValue, 2);
        }
        catch
        {
            binaryResult = "Ошибка: введите корректное шестнадцатеричное число (0-9, A-F)";
        }
    }
}