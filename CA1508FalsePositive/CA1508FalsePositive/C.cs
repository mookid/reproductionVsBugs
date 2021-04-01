using System;
using System.Collections.Generic;

namespace CA1508FalsePositive
{
    public static class Class1
    {
        public static int F<T>(IEnumerable<T> sequence)
        {
            foreach (var value in sequence ?? System.Array.Empty<T>())
            {
                int? hash = value?.GetHashCode();
                return hash ?? 0;
            }
            return -1;
        }

        public static int G(IEnumerable<int?> sequence)
        {
            foreach (var value in sequence ?? System.Array.Empty<int?>())
            {
                int? hash = value?.GetHashCode();
                return hash ?? 0;
            }
            return -1;
        }

        public static int GetValue<T>(R<T> r)
            where T : class
        {
            if (r.Prop is S s)
            {
                return s.Value;
            }
            return -1;
        }

        public static int GetValue2<T>(R<T> r)
        {
            if (r.Prop is S s)
            {
                return s.Value;
            }
            return -1;
        }
    }

    public class R<T> 
    {
        public T Prop { get; set; }
    }

    public class S
    {
        public int Value { get; set; }
    }
}
