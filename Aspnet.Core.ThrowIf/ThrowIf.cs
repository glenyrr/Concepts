using System;

namespace Aspnet.Core.ThrowIf
{
    public class ThrowIf
    {
        public static void ArgumentIsNull(object argument, string argumentException)
        {
            if (argument == null) throw new ArgumentNullException(argumentException);
        }
        public static void ArgumentIsNullOrWhiteSpace(string argument, string argumentException)
        {            
            if (string.IsNullOrWhiteSpace(argument)) throw new ArgumentException(argumentException);
        }
        public static void ArgumentIsZero(int argument, string argumentException)
        {
            if (argument == 0) throw new ArgumentException(argumentException);
        }
    }
}
