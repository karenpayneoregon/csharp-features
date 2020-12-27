using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExpressions_basics.Classes
{
    public class StartupSamples
    {
        public enum TrafficLightState
        {
            Red,
            Yellow,
            Green
        };

        public static TrafficLightState GetNextLight(TrafficLightState currentLight) => currentLight switch
        {
            TrafficLightState.Red => TrafficLightState.Yellow,
            TrafficLightState.Yellow => TrafficLightState.Green,
            TrafficLightState.Green => TrafficLightState.Red,
            _ => throw new InvalidTrafficLightState()
        };

        public static void TrafficCodeSample()
        {
            TrafficLightState originalLightState = TrafficLightState.Yellow;
            TrafficLightState currentTrafficLightState = GetNextLight(originalLightState);
            Console.WriteLine(currentTrafficLightState.ToString());
        }

        public static void Example1(Person person)
        {
            switch (person.LastName)
            {
                // type followed by designation
                // variable, name, will always be non-null if matched
                // only matches values assignable from the given type
                //
                // used pattern matching
                //
                case { } lastName:
                    Console.WriteLine($"Hello, {person.FirstName} {lastName}!");
                    break;

                // only matches null values
                case null:
                    Console.WriteLine($"Hello, user!");
                    break;
            }
        }
        public static void Example2(Person person)
        {
            if (person.LastName is { } lastName)
            {
                Console.WriteLine($"Hello, {person.FirstName} {lastName}!");
            }
            else if (person.LastName == null)
            {
                Console.WriteLine($"Hello, user!");
            }
        }
    }
}
