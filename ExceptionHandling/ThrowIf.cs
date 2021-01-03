using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public static class ThrowIf
    {
        public static class Argument
        {
            public static void IsNull<T>(T argument, string name)
            {
                if (argument is null)
                {
                    throw new ArgumentNullException(name);
                }
            }
        }
    }

#if ThrowMeDemo
    public class ThrowIfExample
    {
        public void Process(Foo foo)
        {
            ThrowIf.Argument.IsNull(foo, nameof(foo));
        }
    }

    public class Foo { }    
#endif

}
