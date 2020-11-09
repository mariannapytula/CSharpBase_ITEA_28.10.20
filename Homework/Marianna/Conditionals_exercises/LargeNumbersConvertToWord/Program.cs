using System;

namespace LargeNumbersConvertToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] units = new string[] { "ONE ", "TWO ", "THREE ", "FOUR ", "FIVE ", "SIX ", "SEVEN ", "EIGHT ", "NINE ", "TEN ", "ELEVEN ", "TWELEVE ", "THIRTEEN ", "FOURTEEN ", "FIFTEEN ", "SIXTEEN ", "SEVENTEEN ", "EIGHTEEN ", "NINTEEN " };
            string[] tens = new string[] { "TEN ", "TWENTY ", "THIRTY ", "FOURTY ", "FIFTY ", "SIXTY ", "SEVENTY ", "EIGHTY ", "NINTY " };
            int i, num;
            string result = "";
            Console.Write("Enter number here in range 1-999 : ");
            num = int.Parse(Console.ReadLine());
            if (num > 99 && num < 1000)
            {
                i = num / 100;
                result = units[i - 1] + "HUNDRED ";
                num = num % 100;
            }//if
            if (num > 19 && num < 100)
            {
                i = num / 10;
                result = result + tens[i - 1];
                num = num % 10;
            }//if
            if (num < 20 && num > 0)
                result += units[num - 1];
            Console.WriteLine("The number you entered: " + result);
            Console.ReadLine();
        }
    }
    }

