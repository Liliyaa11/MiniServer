using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Surver.Exceptions
{
    internal class stringExaptions
    {
        public static Capitalize(CallConvThiscall string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            return char.ToUpper(text[0]) + text.Substring(1).ToLower();

        }
    }
}
