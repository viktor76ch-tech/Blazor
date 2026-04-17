using Microsoft.AspNetCore.Components;

namespace Numerics.Components.Pages;

public partial class Bin2Hex : ComponentBase
{
    private string binaryInput = "";
    private string hexResult = "";

    protected string BinaryInput
    {
        get => binaryInput;
        set
        {
            binaryInput = value;
            ConvertBinToHex();
        }
    }

    protected string HexResult => hexResult;

    private void ConvertBinToHex()
    {
        if (string.IsNullOrWhiteSpace(BinaryInput))
        {
            hexResult = "";
            return;
        }

        try
        {
            int decimalValue = Convert.ToInt32(BinaryInput, 2);
            hexResult = Convert.ToString(decimalValue, 16).ToUpper();
        }
        catch
        {
            hexResult = "Ошибка: введите корректное двоичное число (только 0 и 1)";
        }
    }
}