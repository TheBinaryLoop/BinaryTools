using System;

namespace BinaryTools
{
    /// <summary>
    /// A collection of mathematic functions.
    /// </summary>
    public static partial class Mathematics
    {
        /// <summary>
        /// Calculates the half life of a radioactive substance.
        /// </summary>
        /// <param name="disintegrationConstant">The disintegration constant.</param>
        /// <returns>The calculated half life.</returns>
        public static Double HalfLife(Double disintegrationConstant)
        {
            return 0.693D / disintegrationConstant;
        }

        /// <summary>
        /// Converts the specified amount of celcius to fahrenheit.
        /// </summary>
        /// <param name="celcius">The temperature to be converted.</param>
        /// <returns>The converted temparature in fahrenheit.</returns>
        public static Double CelciusToFahrenheit(Double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        /// <summary>
        /// Converts the specified amount of celcius to kelvin.
        /// </summary>
        /// <param name="celcius">The temperature to be converted.</param>
        /// <returns>The converted temparature in kelvin.</returns>
        public static Double CelciusToKelvin(Double celcius)
        {
            return celcius + 273.15;
        }

        /// <summary>
        /// Converts the specified amount of fahrenheit to celcius.
        /// </summary>
        /// <param name="fahrenheit">The temperature to be converted.</param>
        /// <returns>The converted temparature in celcius.</returns>
        public static Double FahrenheitToCelcius(Double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Converts the specified amount of fahrenheit to kelvin.
        /// </summary>
        /// <param name="fahrenheit">The temperature to be converted.</param>
        /// <returns>The converted temparature in kelvin.</returns>
        public static Double FahrenheitToKelvin(Double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9 + 273.15;
        }

        /// <summary>
        /// Converts the specified amount of kelvin to celcius.
        /// </summary>
        /// <param name="kelvin">The temperature to be converted.</param>
        /// <returns>The converted temparature in celcius.</returns>
        public static Double KelvinToCelcius(Double kelvin)
        {
            return kelvin - 273.15;
        }

        /// <summary>
        /// Converts the specified amount of kelvin to fahrenheit.
        /// </summary>
        /// <param name="kelvin">The temperature to be converted.</param>
        /// <returns>The converted temparature in fahrenheit.</returns>
        public static Double KelvinToFahrenheit(Double kelvin)
        {
            return (kelvin - 273.15) * 9 / 5 + 32;
        }

        /// <summary>
        /// Converts radians to degrees.
        /// </summary>
        /// <param name="radians">The value to be converted.</param>
        /// <returns>The converted value in degrees.</returns>
        public static Double RadiansToDegrees(Double radians)
        {
            return (radians * 180) / Math.PI;
        }

        /// <summary>
        /// Converts degrees to radians.
        /// </summary>
        /// <param name="degrees">The value to be converted.</param>
        /// <returns>The converted value in radians.</returns>
        public static Double DegreesToRadians(Double degrees)
        {
            return (degrees * Math.PI) / 180;
        }
    }
}
