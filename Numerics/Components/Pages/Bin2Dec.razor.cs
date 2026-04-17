using Microsoft.AspNetCore.Components;

namespace Numerics.Components.Pages;

public partial class Bin2Dec : ComponentBase
{
    private string binaryInput = "";
    private string decimalResult = "";

    protected string BinaryInput
    {
        get => binaryInput;
        set
        {
            binaryInput = value;
            ConvertBinToDec();
        }
    }

    protected string DecimalResult => decimalResult;

    private void ConvertBinToDec()
    {
        if (string.IsNullOrWhiteSpace(BinaryInput))
        {
            decimalResult = "";
            return;
        }

        try
        {
            decimalResult = Convert.ToInt32(BinaryInput, 2).ToString();
        }
        catch
        {
            decimalResult = "Ошибка: введите корректное двоичное число (только 0 и 1)";
        }
    }
}