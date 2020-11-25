using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class EventExtensions
    {
        /// <summary>
        /// Creates a wrapper for the given event handler which unsubscribes from the event source immediately
        /// prior to calling the given event handler.
        /// </summary>
        /// <param name="handler">Handler that will be wrapped.</param>
        /// <param name="remove">Action to remove the wrapped handler. (wrapper =&gt; source.MyEvent -= wrapper);</param>
        /// <returns>Wrapped handler</returns>
        /// <example>
        /// <code>
        ///     source.TestEvent += new EventHandler(source_TestEvent)
        ///        .HandleOnce(wrapper => source.TestEvent -= wrapper);
        /// </code>
        /// </example>
        public static EventHandler HandleOnce(this EventHandler handler, Action<EventHandler> remove)
        {
            EventHandler wrapper = null;

            wrapper = delegate (object sender, EventArgs e)
            {
                remove(wrapper);
                handler(sender, e);
            };

            return wrapper;
        }
    }
}
