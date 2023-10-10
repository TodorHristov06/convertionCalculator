using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertionCalculator
{
    internal class NumberConverter
    {
        public static int BinaryToDecimal(string binaryNumber)
        {
            int num = int.Parse(binaryNumber);
            int decVal = 0;
            int baseVal = 1;

            while (num > 0)
            {
                int rem = num % 10;
                decVal += rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }

            return decVal;
        }

        public static int OctalToDecimal(string octalNumber)
        {
            int num = int.Parse(octalNumber);
            int decVal = 0;
            int baseVal = 1;

            while (num > 0)
            {
                int rem = num % 10;
                decVal += rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 8;
            }

            return decVal;
        }

        public static int HexadecimalToDecimal(string hexadecimalNumber)
        {
            int decVal = 0;
            int baseVal = 1;

            for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
            {
                char hexChar = hexadecimalNumber[i];
                int hexDigit = (hexChar >= '0' && hexChar <= '9') ? hexChar - '0' : (hexChar - 'A' + 10);
                decVal += hexDigit * baseVal;
                baseVal *= 16;
            }

            return decVal;
        }

        public static string DecimalToBinary(int decimalNumber)
        {
            string binaryResult = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binaryResult = remainder.ToString() + binaryResult;
                decimalNumber /= 2;
            }
            return binaryResult;
        }

        public static string DecimalToOctal(int decimalNumber)
        {
            string octalResult = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 8;
                octalResult = remainder.ToString() + octalResult;
                decimalNumber /= 8;
            }
            return octalResult;
        }

        public static string DecimalToHexadecimal(int decimalNumber)
        {
            string hexResult = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 16;
                if (remainder < 10)
                    hexResult = remainder.ToString() + hexResult;
                else
                    hexResult = (char)(remainder - 10 + 'A') + hexResult;
                decimalNumber /= 16;
            }
            return hexResult;
        }
    }
}
