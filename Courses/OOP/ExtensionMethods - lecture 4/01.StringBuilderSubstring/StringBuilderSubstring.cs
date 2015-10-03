namespace ExtensionMethods
{
    using System;
    using System.Text;

    public static class ExtensionsStringBuilder
    {

        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder resultStringBuilder = new StringBuilder();

            if (input.Length <= index + length)
                throw new IndexOutOfRangeException("The length of the substring exceeds the length of the input.");

            resultStringBuilder.Append(input.ToString().Substring(index, length));
            return resultStringBuilder;
        }

        public static void Main()
        {
            StringBuilder testString = new StringBuilder();
                
            testString.Append("This is a test string");

            StringBuilder resultString = testString.Substring(5, 10);

            Console.WriteLine(resultString.ToString());
        }
    }
}
