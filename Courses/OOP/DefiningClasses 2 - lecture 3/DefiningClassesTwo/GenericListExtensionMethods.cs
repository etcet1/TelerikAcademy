namespace DefineClassesTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class GenericListExtension
    {
        public static T Min<T>(this GenericList<T> genericList) where T : IComparable
        {
            if (genericList.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
            dynamic min = genericList[0];
            for (int i = 1; i < genericList.Count; i++)
            {
                if (genericList[i] < min)
                {
                    min = genericList[i];
                }
            }
            return (T)min;
        }

        public static T Max<T>(this GenericList<T> genericList) where T : IComparable
        {
            if (genericList.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
            dynamic max = genericList[0];
            for (int i = 1; i < genericList.Count; i++)
            {
                if (genericList[i] > max)
                {
                    max = genericList[i];
                }
            }
            return (T)max;
        }

    }
}
