using convertionCalculator;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

static int GetBaseChoice()
{
    int choice;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
        {
            return choice;
        }
        else
        {
            Console.WriteLine("Моля, въведете валиден избор.");
        }
    }
}

Console.WriteLine("Добре дошли в конвертора на бройни системи!");
Console.WriteLine("Моля, изберете бройна система за вход:");
Console.WriteLine("1. Двоична");
Console.WriteLine("2. Десетична");
Console.WriteLine("3. Осмична");
/*Console.WriteLine("4. Шестнадесетична");*/

int inputBase = GetBaseChoice();

Console.WriteLine("Въведете числото за конвертиране:");
string inputNumber = Console.ReadLine();

int decimalNumber;

switch (inputBase)
{
    case 1: // Двоична
        decimalNumber = NumberConverter.BinaryToDecimal(inputNumber);
        break;
    case 2: // Десетична
        decimalNumber = int.Parse(inputNumber);
        break;
    case 3: // Осмична
        decimalNumber = NumberConverter.OctalToDecimal(inputNumber);
        break;
    case 4: // Шестнадесетична
        decimalNumber = NumberConverter.HexadecimalToDecimal(inputNumber);
        break;
    default:
        Console.WriteLine("Невалиден избор.");
        return;
}

Console.WriteLine("Моля, изберете бройна система за изход:");
Console.WriteLine("1. Двоична");
Console.WriteLine("2. Десетична");
Console.WriteLine("3. Осмична");
Console.WriteLine("4. Шестнадесетична");

int outputBase = GetBaseChoice();

string result;

switch (outputBase)
{
    case 1: // Двоична
        result = NumberConverter.DecimalToBinary(decimalNumber);
        break;
    case 2: // Десетична
        result = decimalNumber.ToString();
        break;
    case 3: // Осмична
        result = NumberConverter.DecimalToOctal(decimalNumber);
        break;
    case 4: // Шестнадесетична
        result = NumberConverter.DecimalToHexadecimal(decimalNumber);
        break;
    default:
        Console.WriteLine("Невалиден избор.");
        return;
}

Console.WriteLine($"Резултатът е: {result}");



