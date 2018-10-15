using System;
using System.Security;

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

      /// <summary>
      /// Displays a password dialog that masks the entered text with the specified char.
      /// </summary>
      /// <param name="escapeCharacter">The character used to mask the text.</param>
      /// <returns><see cref="SecureString"/></returns>
      public static SecureString GetPassword(char escapeCharacter = '*') {
         SecureString pwd = new SecureString();
         while (true) {
            ConsoleKeyInfo i = Console.ReadKey(true);
            if (i.Key == ConsoleKey.Enter) {
               break;
            }
            else if (i.Key == ConsoleKey.Backspace) {
               if (pwd.Length > 0) {
                  pwd.RemoveAt(pwd.Length - 1);
                  Console.Write("\b \b");
               }
            }
            else if (i.KeyChar != '\u0000') // KeyChar == '\u0000' if the key pressed does not correspond to a printable character, e.g. F1, Pause-Break, etc
            {
               pwd.AppendChar(i.KeyChar);
               Console.Write(escapeCharacter);
            }
         }
         return pwd;
      }

   }
}
