using System;

namespace BinaryTools
{
    public static class ConsoleEx
    {
      /// <summary>
      /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
      /// </summary>
      /// <param name="value">The value to write.</param>
      /// <param name="foregroundColor">The foreground color to use.</param>
      /// <param name="backgrounColor">The background color to use.</param>
      /// <exception cref="System.IO.IOException"></exception>
      public static void WriteLine(object value, ConsoleColor foregroundColor = ConsoleColor.Gray, ConsoleColor backgrounColor = ConsoleColor.Black) {
         ConsoleColor fgColor = Console.ForegroundColor;
         ConsoleColor bgColor = Console.BackgroundColor;
         if (Console.ForegroundColor != foregroundColor) Console.ForegroundColor = foregroundColor;
         if (Console.BackgroundColor != backgrounColor) Console.BackgroundColor = backgrounColor;
         Console.WriteLine(value);
         if (Console.ForegroundColor != fgColor) Console.ForegroundColor = fgColor;
         if (Console.BackgroundColor != bgColor) Console.BackgroundColor = bgColor;
      }
    }
}
