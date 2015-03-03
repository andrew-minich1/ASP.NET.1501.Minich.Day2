using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CustomFormatterLogicLayer
{
    public class HexCustomFormatter : ICustomFormatter, IFormatProvider
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        public string Format(string format, object argument, IFormatProvider formatProvider)
        {
            if (argument is int && format == "HEX")
            {
                StringBuilder result = new StringBuilder();
                ConvertToHex((int)argument, result);
                return result.ToString();
            }
            else
            {
                if (argument is IFormattable)
                    return ((IFormattable)argument).ToString(format, CultureInfo.CurrentCulture);
                else if (argument != null)
                    return argument.ToString();
                else
                    return String.Empty;
            }
        }

        private void ConvertToHex(int number, StringBuilder result)
        {
            int num = number;
            int current;
            do
            {
                current = num % 16;
                if (current < 10)
                {
                    result.Insert(0, current);
                }
                else
                {
                    switch (current)
                    {
                        case 10:
                            result.Insert(0, 'A');
                            break;
                        case 11:
                            result.Insert(0, 'B');
                            break;
                        case 12:
                            result.Insert(0, 'C');
                            break;
                        case 13:
                            result.Insert(0, 'D');
                            break;
                        case 14:
                            result.Insert(0, 'E');
                            break;
                        case 15:
                            result.Insert(0, 'F');
                            break;
                    }
                }
                num = num / 16;
            }
            while (num != 0);
        }

    }
}
