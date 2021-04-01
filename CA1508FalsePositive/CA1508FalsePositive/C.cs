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
    }
}
