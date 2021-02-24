using System.Collections.Generic;
using System.Linq;

namespace Source
{
    public static class Extension
    {
        public static KeyValuePair<T, U>? FirstOrNullStruct<T,U>(this IDictionary<T,U> list, U value)
        {
            var found = list.FirstOrDefault(kvp => kvp.Value.Equals(value));
            if(found.Equals(default(KeyValuePair<T,U>)))
            {
                return null;
            }
		
            return found;
        }
    }
}