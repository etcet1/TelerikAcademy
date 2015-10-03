namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> enumerable)
        {
            dynamic sum = 0;
            foreach (var item in enumerable)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumerable)
        {
            dynamic product = 0;
            foreach (var item in enumerable)
            {
                product *= (dynamic)item;
                if (product == 0)
                    break;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> enumerable)
        {
            dynamic min = long.MaxValue;
            foreach (var item in enumerable)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumerable)
        {
            dynamic max = long.MinValue;
            foreach (var item in enumerable)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> enumerable)
        {
            dynamic average = 0, counter = 0;
            foreach (var item in enumerable)
            {
                average += item;
                counter++;
            }
            if (counter == 0)
                throw new ArgumentException("The passed collection is empty.");
            return average / counter;
        }
    }
}