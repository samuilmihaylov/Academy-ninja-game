namespace AcademyNinja.Common.Validator
{
    using System;

    public class Validator
    {
        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void ValidateIfZero(int value, string message)
        {
            if (value == 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
