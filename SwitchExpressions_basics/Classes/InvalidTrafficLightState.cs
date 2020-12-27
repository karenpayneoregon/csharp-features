using System;

namespace SwitchExpressions_basics.Classes
{
    /// <summary>
    /// Used for invalid enum being passed in StartupSamples class
    /// </summary>
    public class InvalidTrafficLightState : Exception
    {
        public InvalidTrafficLightState()
        {
            
        }
        public InvalidTrafficLightState(string message) : base(message)
        {
        }

        public InvalidTrafficLightState(string message, Exception inner) : base(message, inner)
        {
        }
    }
}