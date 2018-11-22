using System;
using System.Linq;
using System.Security;

namespace BinaryTools
{
    /// <summary>
    /// An alternative to the native <see cref="Console"/> class with many helpful methods
    /// </summary>
    public static class ConsoleEx
    {
        #region Wrapper Section

        #region Properties

        /// <summary>
        /// Gets or sets the background color of the console.
        /// </summary>
        /// <value>A value that specifies the background color of the console; that is, the color that appears behind each character. The default is black.</value>
        /// <exception cref="ArgumentException">
        /// The color specified in a set operation is not a valid member of <see cref="ConsoleColor"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static ConsoleColor BackgroundColor
        {
            get
            {
                return Console.BackgroundColor;
            }
            set
            {
                Console.BackgroundColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the buffer area.
        /// </summary>
        /// <value>The current height, in rows, of the buffer area.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value in a set operation is less than or equal to zero. 
        /// -or- 
        /// The value in a set operation is greater than or equal to <see cref="Int16.MaxValue"/>. 
        /// -or- 
        /// The value in a set operation is less than <see cref="WindowTop"/> + <see cref="WindowHeight"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static int BufferHeight
        {
            get
            {
                return Console.BufferHeight;
            }
            set
            {
                Console.BufferHeight = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the buffer area.
        /// </summary>
        /// <value>
        /// The current width, in columns, of the buffer area.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value in a set operation is less than or equal to zero. 
        /// -or- 
        /// The value in a set operation is greater than or equal to <see cref="Int16.MaxValue"/>. 
        /// -or- 
        /// The value in a set operation is less than <see cref="WindowLeft"/> + <see cref="WindowWidth"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static int BufferWidth
        {
            get
            {
                return Console.BufferWidth;
            }
            set
            {
                Console.BufferWidth = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off.
        /// </summary>
        /// <value>
        /// true if CAPS LOCK is turned on; false if CAPS LOCK is turned off.
        /// </value>
        public static bool CapsLock
        {
            get
            {
                return Console.CapsLock;
            }
        }

        /// <summary>
        /// Gets or sets the column position of the cursor within the buffer area.
        /// </summary>
        /// <value>
        /// The current position, in columns, of the cursor.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value in a set operation is less than zero. 
        /// -or- 
        /// The value in a set operation is greater than or equal to <see cref="BufferWidth"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static int CursorLeft
        {
            get
            {
                return Console.CursorLeft;
            }
            set
            {
                Console.CursorLeft = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the cursor within a character cell.
        /// </summary>
        /// <value>
        /// The size of the cursor expressed as a percentage of the height of a character cell. The property value ranges from 1 to 100.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value specified in a set operation is less than 1 or greater than 100.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static int CursorSize
        {
            get
            {
                return Console.CursorSize;
            }
            set
            {
                Console.CursorSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the row position of the cursor within the buffer area.
        /// </summary>
        /// <value>
        /// The current position, in rows, of the cursor.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value in a set operation is less than zero. 
        /// -or- 
        /// The value in a set operation is greater than or equal to <see cref="BufferHeight"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static int CursorTop
        {
            get
            {
                return Console.CursorTop;
            }
            set
            {
                Console.CursorTop = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the cursor is visible.
        /// </summary>
        /// <value>
        /// true if the cursor is visible; otherwise, false.
        /// </value>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static bool CursorVisible
        {
            get
            {
                return Console.CursorVisible;
            }
            set
            {
                Console.CursorVisible = value;
            }
        }

        /// <summary>
        /// Gets the standard error output stream.
        /// </summary>
        /// <value>
        /// A <see cref="System.IO.TextWriter"/> that represents the standard error output stream.
        /// </value>
        public static System.IO.TextWriter Error
        {
            get
            {
                return Console.Error;
            }
        }

        /// <summary>
        /// Gets or sets the foreground color of the console.
        /// </summary>
        /// <value>
        /// A <see cref="ConsoleColor"/> that specifies the foreground color of the console; that is, the color of each character that is displayed. The default is gray.
        /// </value>
        /// <exception cref="ArgumentException">
        /// The color specified in a set operation is not a valid member of <see cref="ConsoleColor"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static ConsoleColor ForegroundColor
        {
            get
            {
                return Console.ForegroundColor;
            }
            set
            {
                Console.ForegroundColor = value;
            }
        }

        /// <summary>
        /// Gets the standard input stream.
        /// </summary>
        /// <value>
        /// A <see cref="System.IO.TextReader"/> that represents the standard input stream.
        /// </value>
        public static System.IO.TextReader In
        {
            get
            {
                return Console.In;
            }
        }

        /// <summary>
        /// Gets or sets the encoding the console uses to read input.
        /// </summary>
        /// <value>
        /// The encoding used to read console input.
        /// </value>
        /// <exception cref="ArgumentNullException">
        /// The property value in a set operation is null.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An error occurred during the execution of this operation.
        /// </exception>
        /// <exception cref="SecurityException">
        /// Your application does not have permission to perform this operation.
        /// </exception>
        public static System.Text.Encoding InputEncoding
        {
            get
            {
                return Console.InputEncoding;
            }
            set
            {
                Console.InputEncoding = value;
            }
        }

#if NET45_OR_GREATER

        /// <summary>
        /// Gets a value that indicates whether the error output stream has been redirected from the standard error stream.
        /// </summary>
        /// <value>
        /// true if error output is redirected; otherwise, false.
        /// </value>
        public static bool IsErrorRedirected
        {
            get
            {
                return Console.IsErrorRedirected;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether input has been redirected from the standard input stream.
        /// </summary>
        /// <value>
        /// true if input is redirected; otherwise, false.
        /// </value>
        public static bool IsInputRedirected
        {
            get
            {
                return Console.IsInputRedirected;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether output has been redirected from the standard output stream.
        /// </summary>
        /// <value>
        /// true if output is redirected; otherwise, false.
        /// </value>
        public static bool IsOutputRedirected
        {
            get
            {
                return Console.IsOutputRedirected;
            }
        }

#endif

        /// <summary>
        /// Gets a value indicating whether a key press is available in the input stream.
        /// </summary>
        /// <value>
        /// true if a key press is available; otherwise, false.
        /// </value>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Standard input is redirected to a file instead of the keyboard.
        /// </exception>
        public static bool KeyAvailable
        {
            get
            {
                return Console.KeyAvailable;
            }
        }

        /// <summary>
        /// Gets the largest possible number of console window rows, based on the current font and screen resolution.
        /// </summary>
        /// <value>
        /// The height of the largest possible console window measured in rows.
        /// </value>
        public static int LargestWindowHeight
        {
            get
            {
                return Console.LargestWindowHeight;
            }
        }

        /// <summary>
        /// Gets the largest possible number of console window columns, based on the current font and screen resolution.
        /// </summary>
        /// <value>
        /// The width of the largest possible console window measured in columns.
        /// </value>
        public static int LargestWindowWidth
        {
            get
            {
                return Console.LargestWindowWidth;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off.
        /// </summary>
        /// <value>
        /// true if NUM LOCK is turned on; false if NUM LOCK is turned off.
        /// </value>
        public static bool NumberLock
        {
            get
            {
                return Console.NumberLock;
            }
        }

        /// <summary>
        /// Gets the standard output stream.
        /// </summary>
        /// <value>
        /// A <see cref="System.IO.TextWriter"/> that represents the standard output stream.
        /// </value>
        public static System.IO.TextWriter Out
        {
            get
            {
                return Console.Out;
            }
        }

        /// <summary>
        /// Gets or sets the encoding the console uses to write output.
        /// </summary>
        /// <value>
        /// The encoding used to write console output.
        /// </value>
        /// <exception cref="ArgumentNullException">
        /// The property value in a set operation is null.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An error occurred during the execution of this operation.
        /// </exception>
        /// <exception cref="SecurityException">
        /// Your application does not have permission to perform this operation.
        /// </exception>
        public static System.Text.Encoding OutputEncoding
        {
            get
            {
                return Console.OutputEncoding;
            }
            set
            {
                Console.OutputEncoding = value;
            }
        }

        /// <summary>
        /// Gets or sets the title to display in the console title bar.
        /// </summary>
        /// <value>
        /// The string to be displayed in the title bar of the console. The maximum length of the title string is 24500 characters.
        /// </value>
        /// <exception cref="InvalidOperationException">
        /// In a get operation, the retrieved title is longer than 24500 characters.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// In a set operation, the specified title is longer than 24500 characters.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// In a set operation, the specified title is null.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static string Title
        {
            get
            {
                return Console.Title;
            }
            set
            {
                Console.Title = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the combination of the <see cref="ConsoleModifiers.Control"/> modifier key and <see cref="ConsoleKey.C"/> console key (Ctrl+C) is treated as ordinary 
        /// input or as an interruption that is handled by the operating system.
        /// </summary>
        /// <value>
        /// true if Ctrl+C is treated as ordinary input; otherwise, false.
        /// </value>
        /// <exception cref="System.IO.IOException">
        /// Unable to get or set the input mode of the console input buffer.
        /// </exception>
        public static bool TreatControlCAsInput
        {
            get
            {
                return Console.TreatControlCAsInput;
            }
            set
            {
                Console.TreatControlCAsInput = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the console window area.
        /// </summary>
        /// <value>
        /// The height of the console window measured in rows.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is less than or equal to 0. 
        /// -or- 
        /// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is greater than or equal to <see cref="Int16.MaxValue"/>. 
        /// -or- 
        /// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is greater than the largest possible window 
        /// width or height for the current screen resolution and console font.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Error reading or writing information.
        /// </exception>
        public static int WindowHeight
        {
            get
            {
                return Console.WindowHeight;
            }
            set
            {
                Console.WindowHeight = value;
            }
        }

        /// <summary>
        /// Gets or sets the leftmost position of the console window area relative to the screen buffer.
        /// </summary>
        /// <value>
        /// The leftmost console window position measured in columns.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// In a set operation, the value to be assigned is less than zero. 
        /// -or- 
        /// As a result of the assignment, <see cref="WindowLeft"/> plus <see cref="WindowWidth"/> would exceed <see cref="BufferWidth"/>.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Error reading or writing information.
        /// </exception>
        public static int WindowLeft
        {
            get
            {
                return Console.WindowLeft;
            }
            set
            {
                Console.WindowLeft = value;
            }
        }

        /// <summary>
        /// Gets or sets the top position of the console window area relative to the screen buffer.
        /// </summary>
        /// <value>
        /// The uppermost console window position measured in rows.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// In a set operation, the value to be assigned is less than zero. 
        /// -or- 
        /// As a result of the assignment, <see cref="WindowTop"/> plus <see cref="WindowHeight"/> would exceed <see cref="BufferHeight"/>.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Error reading or writing information.
        /// </exception>
        public static int WindowTop
        {
            get
            {
                return Console.WindowTop;
            }
            set
            {
                Console.WindowTop = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the console window.
        /// </summary>
        /// <value>
        /// The width of the console window measured in columns.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is less than or equal to 0. 
        /// -or- 
        /// The value of the <see cref="WindowHeight"/> property plus the value of the <see cref="WindowTop"/> property is greater than or equal to <see cref="Int16.MaxValue"/>. 
        /// -or- 
        /// The value of the <see cref="WindowWidth"/> property or the value of the <see cref="WindowHeight"/> property is greater than the largest possible window 
        /// width or height for the current screen resolution and console font.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Error reading or writing information.
        /// </exception>
        public static int WindowWidth
        {
            get
            {
                return Console.WindowWidth;
            }
            set
            {
                Console.WindowWidth = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Plays the sound of a beep through the console speaker.
        /// </summary>
        /// <exception cref="HostProtectionException">
        /// This method was executed on a server, such as SQL Server, that does not permit access to a user interface.
        /// </exception>
        public static void Beep()
        {
            Console.Beep();
        }

        /// <summary>
        /// Plays the sound of a beep of a specified frequency and duration through the console speaker.
        /// </summary>
        /// <param name="frequency">The frequency of the beep, ranging from 37 to 32767 hertz.</param>
        /// <param name="duration">The duration of the beep measured in milliseconds.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// frequency is less than 37 or more than 32767 hertz. 
        /// -or- 
        /// duration is less than or equal to zero.
        /// </exception>
        /// <exception cref="HostProtectionException">
        /// This method was executed on a server, such as SQL Server, that does not permit access to a user interface.
        /// </exception>
        public static void Beep(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }

        /// <summary>
        /// Clears the console buffer and corresponding console window of display information.
        /// </summary>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Copies a specified source area of the screen buffer to a specified destination area.
        /// </summary>
        /// <param name="sourceLeft">The leftmost column of the source area.</param>
        /// <param name="sourceTop">The topmost row of the source area.</param>
        /// <param name="sourceWidth">The number of columns in the source area.</param>
        /// <param name="sourceHeight">The number of rows in the source area.</param>
        /// <param name="targetLeft">The leftmost column of the destination area.</param>
        /// <param name="targetTop">The topmost row of the destination area.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// One or more of the parameters is less than zero. -or- sourceLeft or targetLeft is greater than or equal to BufferWidth. -or- 
        /// sourceTop or targetTop is greater than or equal to BufferHeight. -or- sourceTop + sourceHeight is greater than or equal to 
        /// BufferHeight. -or- sourceLeft + sourceWidth is greater than or equal to BufferWidth.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
        {
            Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
        }

        /// <summary>
        /// Copies a specified source area of the screen buffer to a specified destination area.
        /// </summary>
        /// <param name="sourceLeft">The leftmost column of the source area.</param>
        /// <param name="sourceTop">The topmost row of the source area.</param>
        /// <param name="sourceWidth">The number of columns in the source area.</param>
        /// <param name="sourceHeight">The number of rows in the source area.</param>
        /// <param name="targetLeft">The leftmost column of the destination area.</param>
        /// <param name="targetTop">The topmost row of the destination area.</param>
        /// <param name="sourceChar">The character used to fill the source area.</param>
        /// <param name="sourceForeColor">The foreground color used to fill the source area.</param>
        /// <param name="sourceBackColor">The background color used to fill the source area.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// One or more of the parameters is less than zero. -or- sourceLeft or targetLeft is greater than or equal to BufferWidth. -or- 
        /// sourceTop or targetTop is greater than or equal to BufferHeight. -or- sourceTop + sourceHeight is greater than or equal to 
        /// BufferHeight. -or- sourceLeft + sourceWidth is greater than or equal to BufferWidth.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
        {
            Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
        }

        /// <summary>
        /// Acquires the standard error stream.
        /// </summary>
        /// <returns>The standard error stream.</returns>
        public static System.IO.Stream OpenStandardError()
        {
            return Console.OpenStandardError();
        }

        /// <summary>
        /// Acquires the standard error stream, which is set to a specified buffer size.
        /// </summary>
        /// <param name="bufferSize">The internal stream buffer size.</param>
        /// <returns>The standard error stream.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// bufferSize is less than or equal to zero.
        /// </exception>
        public static System.IO.Stream OpenStandardError(int bufferSize)
        {
            return Console.OpenStandardError(bufferSize);
        }

        /// <summary>
        /// Acquires the standard input stream.
        /// </summary>
        /// <returns>The standard input stream.</returns>
        public static System.IO.Stream OpenStandardInput()
        {
            return Console.OpenStandardInput();
        }

        /// <summary>
        /// Acquires the standard input stream, which is set to a specified buffer size.
        /// </summary>
        /// <param name="bufferSize">The internal stream buffer size.</param>
        /// <returns>The standard input stream.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// bufferSize is less than or equal to zero.
        /// </exception>
        public static System.IO.Stream OpenStandardInput(int bufferSize)
        {
            return Console.OpenStandardInput(bufferSize);
        }

        /// <summary>
        /// Acquires the standard output stream.
        /// </summary>
        /// <returns>The standard output stream.</returns>
        public static System.IO.Stream OpenStandardOutput()
        {
            return Console.OpenStandardOutput();
        }

        /// <summary>
        /// Acquires the standard output stream, which is set to a specified buffer size.
        /// </summary>
        /// <param name="bufferSize">The internal stream buffer size.</param>
        /// <returns>The standard output stream.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// bufferSize is less than or equal to zero.
        /// </exception>
        public static System.IO.Stream OpenStandardOutput(int bufferSize)
        {
            return Console.OpenStandardOutput(bufferSize);
        }

        /// <summary>
        /// Reads the next character from the standard input stream.
        /// </summary>
        /// <returns>The next character from the input stream, or negative one (-1) if there are currently no more characters to be read.</returns>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static int Read()
        {
            return Console.Read();
        }

        /// <summary>
        /// Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
        /// </summary>
        /// <returns>
        /// An object that describes the ConsoleKey constant and Unicode character, if any, that correspond to the pressed console key. The 
        /// ConsoleKeyInfo object also describes, in a bitwise combination of ConsoleModifiers values, whether one or more Shift, Alt, or Ctrl 
        /// modifier keys was pressed simultaneously with the console key.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The In property is redirected from some stream other than the console.
        /// </exception>
        public static ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        /// <summary>
        /// Obtains the next character or function key pressed by the user. The pressed key is optionally displayed in the console window.
        /// </summary>
        /// <param name="intercept">Determines whether to display the pressed key in the console window. true to not display the pressed key; otherwise, false.</param>
        /// <returns>
        /// An object that describes the ConsoleKey constant and Unicode character, if any, that correspond to the pressed console key. The 
        /// ConsoleKeyInfo object also describes, in a bitwise combination of ConsoleModifiers values, whether one or more Shift, Alt, or Ctrl 
        /// modifier keys was pressed simultaneously with the console key.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The In property is redirected from some stream other than the console.
        /// </exception>
        public static ConsoleKeyInfo ReadKey(bool intercept)
        {
            return Console.ReadKey(intercept);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream.
        /// </summary>
        /// <returns>The next line of characters from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="OutOfMemoryException">
        /// There is insufficient memory to allocate a buffer for the returned string.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The number of characters in the next line of characters is greater than <see cref="Int16.MaxValue"/>.
        /// </exception>
        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Sets the foreground and background console colors to their defaults.
        /// </summary>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void ResetColor()
        {
            Console.ResetColor();
        }

        /// <summary>
        /// Sets the height and width of the screen buffer area to the specified values.
        /// </summary>
        /// <param name="width">The width of the buffer area measured in columns.</param>
        /// <param name="height">The height of the buffer area measured in rows.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// height or width is less than or equal to zero. 
        /// -or- 
        /// height or width is greater than or equal to <see cref="Int16.MaxValue"/>. 
        /// -or- 
        /// width is less than <see cref="WindowLeft"/> + <see cref="WindowWidth"/>. 
        /// -or- 
        /// height is less than <see cref="WindowTop"/> + <see cref="WindowHeight"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void SetBufferSize(int width, int height)
        {
            Console.SetBufferSize(width, height);
        }

        /// <summary>
        /// Sets the position of the cursor.
        /// </summary>
        /// <param name="left">The column position of the cursor. Columns are numbered from left to right starting at 0.</param>
        /// <param name="top">The row position of the cursor. Rows are numbered from top to bottom starting at 0.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// left or top is less than zero. 
        /// -or- 
        /// left is greater than or equal to <see cref="BufferWidth"/>. 
        /// -or- 
        /// top is greater than or equal to <see cref="BufferHeight"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void SetCursorPosition(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }

        /// <summary>
        /// Sets the <see cref="Error"/> property to the specified <see cref="System.IO.TextWriter"/> object.
        /// </summary>
        /// <param name="newError">
        /// A stream that is the new standard error output.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// newError is null.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The caller does not have the required permission.
        /// </exception>
        public static void SetError(System.IO.TextWriter newError)
        {
            Console.SetError(newError);
        }

        /// <summary>
        /// Sets the <see cref="In"/> property to the specified <see cref="System.IO.TextReader"/> object.
        /// </summary>
        /// <param name="newIn">
        /// A stream that is the new standard input.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// newIn is null.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The caller does not have the required permission.
        /// </exception>
        public static void SetIn(System.IO.TextReader newIn)
        {
            Console.SetIn(newIn);
        }

        /// <summary>
        /// Sets the <see cref="Out"/> property to the specified <see cref="System.IO.TextWriter"/> object.
        /// </summary>
        /// <param name="newOut">
        /// A stream that is the new standard output.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// newOut is null.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The caller does not have the required permission.
        /// </exception>
        public static void SetOut(System.IO.TextWriter newOut)
        {
            Console.SetOut(newOut);
        }

        /// <summary>
        /// Sets the position of the console window relative to the screen buffer.
        /// </summary>
        /// <param name="left">
        /// The column position of the upper left corner of the console window.
        /// </param>
        /// <param name="top">
        /// The row position of the upper left corner of the console window.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// left or top is less than zero. 
        /// -or- 
        /// left + <see cref="WindowHeight"/> is greater than <see cref="BufferWidth"/>. 
        /// -or- 
        /// top + <see cref="WindowHeight"/> is greater than <see cref="BufferWidth"/>.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void SetWindowPosition(int left, int top)
        {
            Console.SetWindowPosition(left, top);
        }

        /// <summary>
        /// Sets the height and width of the console window to the specified values.
        /// </summary>
        /// <param name="width">
        /// The width of the console window measured in columns.
        /// </param>
        /// <param name="height">
        /// The height of the console window measured in rows.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// width or height is less than or equal to zero. 
        /// -or- 
        /// width + <see cref="WindowLeft"/> or height plus <see cref="WindowTop"/> is greater than or equal to <see cref="Int16.MaxValue"/>. 
        /// -or- 
        /// width or height is greater than the largest possible window width or height for the current screen resolution and console font.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The user does not have permission to perform this action.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void SetWindowSize(int width, int height)
        {
            Console.SetWindowSize(width, height);
        }

        /// <summary>
        /// Writes the text representation of the specified objects and variable-length parameter list to the standard output stream using the 
        /// specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// The first object to write using format.
        /// </param>
        /// <param name="arg1">
        /// The second object to write using format.
        /// </param>
        /// <param name="arg2">
        /// The third object to write using format.
        /// </param>
        /// <param name="arg3">
        /// The fourth object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void Write(string format, object arg0, object arg1, object arg2, object arg3)
        {
            Console.Write(format, arg0, arg1, arg2, arg3);
        }

        /// <summary>
        /// Writes the text representation of the specified objects to the standard output stream using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// The first object to write using format.
        /// </param>
        /// <param name="arg1">
        /// The second object to write using format.
        /// </param>
        /// <param name="arg2">
        /// The third object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void Write(string format, object arg0, object arg1, object arg2)
        {
            Console.Write(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Writes the text representation of the specified objects to the standard output stream using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// The first object to write using format.
        /// </param>
        /// <param name="arg1">
        /// The second object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void Write(string format, object arg0, object arg1)
        {
            Console.Write(format, arg0, arg1);
        }

        /// <summary>
        /// Writes the text representation of the specified object to the standard output stream using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// An object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void Write(string format, object arg0)
        {
            Console.Write(format, arg0);
        }

        /// <summary>
        /// Writes the text representation of the specified array of objects to the standard output stream using the specified format 
        /// information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg">
        /// An array of objects to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format or arg is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void Write(string format, params object[] arg)
        {
            Console.Write(format, arg);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(ulong value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(uint value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(string value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the specified subarray of Unicode characters to the standard output stream.
        /// </summary>
        /// <param name="buffer">
        /// An array of Unicode characters.
        /// </param>
        /// <param name="index">
        /// The starting position in buffer.
        /// </param>
        /// <param name="count">
        /// The number of characters to write.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// buffer is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// index or count is less than zero.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// index plus count specify a position that is not within buffer.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <remarks>
        /// This method writes count characters starting at position index of buffer to the standard output stream.
        /// </remarks>
        public static void Write(char[] buffer, int index, int count)
        {
            Console.Write(buffer, index, count);
        }

        /// <summary>
        /// Writes the text representation of the specified object to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write, or null.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(object value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified single-precision floating-point value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(float value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the specified Unicode character value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(char value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the specified array of Unicode characters to the standard output stream.
        /// </summary>
        /// <param name="buffer">
        /// A Unicode character array.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(char[] buffer)
        {
            Console.Write(buffer);
        }

        /// <summary>
        /// Writes the text representation of the specified Boolean value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(bool value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified double-precision floating-point value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(double value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit signed integer value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(int value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit signed integer value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(long value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified <see cref="Decimal"/> value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void Write(decimal value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the text representation of the specified objects and variable-length parameter list, followed by the current line terminator, 
        /// to the standard output stream using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// The first object to write using format.
        /// </param>
        /// <param name="arg1">
        /// The second object to write using format.
        /// </param>
        /// <param name="arg2">
        /// The third object to write using format.
        /// </param>
        /// <param name="arg3">
        /// The fourth object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
        {
            Console.WriteLine(format, arg0, arg1, arg2, arg3);
        }

        /// <summary>
        /// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream 
        /// using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// The first object to write using format.
        /// </param>
        /// <param name="arg1">
        /// The second object to write using format.
        /// </param>
        /// <param name="arg2">
        /// The third object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream 
        /// using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// The first object to write using format.
        /// </param>
        /// <param name="arg1">
        /// The second object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void WriteLine(string format, object arg0, object arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream 
        /// using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg0">
        /// An object to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void WriteLine(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }

        /// <summary>
        /// Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output 
        /// stream using the specified format information.
        /// </summary>
        /// <param name="format">
        /// A composite format string.
        /// </param>
        /// <param name="arg">
        /// An array of objects to write using format.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// format or arg is null.
        /// </exception>
        /// <exception cref="FormatException">
        /// The format specification in format is invalid.
        /// </exception>
        public static void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the 
        /// standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(ulong value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the 
        /// standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(uint value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="buffer">
        /// An array of Unicode characters.
        /// </param>
        /// <param name="index">
        /// The starting position in buffer.
        /// </param>
        /// <param name="count">
        /// The number of characters to write.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// buffer is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// index or count is less than zero.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// index plus count specify a position that is not within buffer.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        /// <remarks>
        /// This method writes count characters starting at position index of buffer to the standard output stream.
        /// </remarks>
        public static void WriteLine(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write, or null.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(object value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the 
        /// standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(float value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the specified Unicode character, followed by the current line terminator, value to the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(char value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="buffer">
        /// A Unicode character array.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(char[] buffer)
        {
            Console.WriteLine(buffer);
        }

        /// <summary>
        /// Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output 
        /// stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(bool value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to 
        /// the standard output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(double value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard 
        /// output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(int value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard
        /// output stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(long value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the text representation of the specified <see cref="Decimal"/> value, followed by the current line terminator, to the standard output 
        /// stream.
        /// </summary>
        /// <param name="value">
        /// The value to write.
        /// </param>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine(decimal value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Writes the current line terminator to the standard output stream.
        /// stream.
        /// </summary>
        /// <exception cref="System.IO.IOException">
        /// An I/O error occurred.
        /// </exception>
        public static void WriteLine()
        {
            Console.WriteLine();
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when the <see cref="ConsoleModifiers.Control"/> modifier key (Ctrl) and either the <see cref="ConsoleKey.C"/> console key (C) or the Break key are pressed simultaneously (Ctrl+C 
        /// or Ctrl+Break).
        /// </summary>
        public static event ConsoleCancelEventHandler CancelKeyPress
        {
            add
            {
                Console.CancelKeyPress += value;
            }
            remove
            {
                Console.CancelKeyPress -= value;
            }
        }

        #endregion

        #endregion

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="foregroundColor">The foreground color to use.</param>
        /// <param name="backgrounColor">The background color to use.</param>
        /// <exception cref="System.IO.IOException"></exception>
        public static void WriteLine(object value, ConsoleColor foregroundColor = ConsoleColor.Gray, ConsoleColor backgrounColor = ConsoleColor.Black)
        {
            ConsoleColor fgColor = Console.ForegroundColor;
            ConsoleColor bgColor = Console.BackgroundColor;
            if (Console.ForegroundColor != foregroundColor) Console.ForegroundColor = foregroundColor;
            if (Console.BackgroundColor != backgrounColor) Console.BackgroundColor = backgrounColor;
            Console.WriteLine(value);
            if (Console.ForegroundColor != fgColor) Console.ForegroundColor = fgColor;
            if (Console.BackgroundColor != bgColor) Console.BackgroundColor = bgColor;
        }

        /// <summary>
        /// Writes the specified string, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="foregroundColor">The foreground color to use.</param>
        /// <param name="backgrounColor">The background color to use.</param>
        /// <exception cref="System.IO.IOException"></exception>
        public static void WriteLine(string value, ConsoleColor foregroundColor = ConsoleColor.Gray, ConsoleColor backgrounColor = ConsoleColor.Black)
        {
            ConsoleColor fgColor = Console.ForegroundColor;
            ConsoleColor bgColor = Console.BackgroundColor;
            if (Console.ForegroundColor != foregroundColor) Console.ForegroundColor = foregroundColor;
            if (Console.BackgroundColor != backgrounColor) Console.BackgroundColor = backgrounColor;
            Console.WriteLine(value);
            if (Console.ForegroundColor != fgColor) Console.ForegroundColor = fgColor;
            if (Console.BackgroundColor != bgColor) Console.BackgroundColor = bgColor;
        }

        /// <summary>
        /// Writes the specified text centered, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="foregroundColor">The foreground color to use.</param>
        /// <param name="backgrounColor">The background color to use.</param>
        public static void WriteLineCentered(string value, ConsoleColor foregroundColor = ConsoleColor.Gray, ConsoleColor backgrounColor = ConsoleColor.Black)
        {
            SetCursorPosition((WindowWidth - value.Length) / 2, CursorTop);
            WriteLine(value, foregroundColor, backgrounColor);
        }

        /// <summary>
        /// Displays a password dialog that masks the entered text with the specified char.
        /// </summary>
        /// <param name="escapeCharacter">The character used to mask the text.</param>
        /// <returns><see cref="SecureString"/></returns>
        public static SecureString GetPassword(char escapeCharacter = '*')
        {
            SecureString pwd = new SecureString();
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if (pwd.Length > 0)
                    {
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


        public static void PrintConsoleHeader(string title, string[] content, bool centerContent = false)
        {
            if (content == null) throw new ArgumentNullException("content");
            if (content.Length <= 0) throw new ArgumentOutOfRangeException("content");
            if (string.IsNullOrEmpty(title)) title = string.Empty;

            char[] borderCharacters = new char[]
            {
                '\u2550', // 0 => ═
                '\u2551', // 1 => ║
                '\u2554', // 2 => ╔
                '\u2557', // 3 => ╗
                '\u255a', // 4 => ╚
                '\u255d', // 5 => ╝
                '\u2560', // 6 => ╠
                '\u2563'  // 7 => ╣
            };
            string[] templateStrings = new string[]
            {
                $"{borderCharacters[2]}{{0}}{borderCharacters[3]}", // 0 => Top line without title
                $"{borderCharacters[2]}{{0}}{borderCharacters[7]} {{1}} {borderCharacters[6]}{{0}}{borderCharacters[3]}", // 1 => Top line with title
                $"{borderCharacters[1]} {{0}} {borderCharacters[1]}", // 2 => Normal content line
                $"{borderCharacters[4]}{{0}}{borderCharacters[5]}", // 3 => Normal bottom line
            };

            if (title.Length % 2 != 0) title += " ";
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Length % 2 != 0) content[i] += " ";
            }
            int longestLine = content.OrderByDescending(s => s.Length).FirstOrDefault().Length + 4;
            if (!string.IsNullOrEmpty(title))
            {
                if (title.Length > longestLine) longestLine = title.Length + 6;
                WriteLineCentered(string.Format(templateStrings[1], new string(borderCharacters[0], (longestLine - 6 - title.Length) / 2), title));
                foreach (string line in content)
                {
                    WriteLineCentered(string.Format(templateStrings[2], centerContent ? string.Format("{0}{1}{0}", new string(' ', (longestLine - 4 - line.Length) / 2), line) : line + new string(' ', longestLine - 4 - line.Length)));
                }
                WriteLineCentered(string.Format(templateStrings[3], new string(borderCharacters[0], longestLine - 2)));
            }
            else
            {
                WriteLineCentered(string.Format(templateStrings[0], new string(borderCharacters[0], longestLine - 2)));
                foreach (string line in content)
                {
                    WriteLineCentered(string.Format(templateStrings[2], centerContent ? string.Format("{0}{1}{0}", new string(' ', (longestLine - 4 - line.Length) / 2), line) : line + new string(' ', longestLine - 4 - line.Length)));
                }
                WriteLineCentered(string.Format(templateStrings[3], new string(borderCharacters[0], longestLine - 2)));
            }
        }

    }
}
