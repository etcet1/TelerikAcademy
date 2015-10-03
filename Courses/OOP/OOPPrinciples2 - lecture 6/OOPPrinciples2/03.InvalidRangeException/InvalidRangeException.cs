namespace InvalidRangeException
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class InvalidRangeException<T> : Exception
    {

        public string message;
        public T minValue;
        public T maxValue;

        public T MinValue { get; private set; }

        public T MaxValue { get; private set; }

        public string ExMessage { get; set; }

        public InvalidRangeException()
        {
        }

        public InvalidRangeException(string message)
        {
            this.ExMessage = message;
        }

        public InvalidRangeException(string message, T minValue, T maxValue)
            : this(message)
        {
            this.MinValue = minValue;
            this.MaxValue = MaxValue;
        }
    }
}
