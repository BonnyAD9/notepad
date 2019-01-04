using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mine
using ConsoleNotepad;

namespace ConsoleNotepad
{
    /// <summary>
    /// This class incule some of command sets wich cn be used more times
    /// </summary>
    class ComSets
    {
        /// <summary>
        /// Write " > " and read text from console
        /// </summary>
        /// <returns>Text from console</returns>
        public static string ConsoleRead()
        {
            Console.Write(" > ");
            string ss = Console.ReadLine();
            Console.WriteLine();
            return ss;
        }

        /// <summary>
        /// Wtite "s" and read text from console
        /// </summary>
        /// <param name="s">Text wich will be before reading from console</param>
        /// <returns></returns>
        public static string ConsoleRead(string s)
        {
            Console.Write(s);
            string ss = Console.ReadLine();
            Console.WriteLine();
            return ss;
        }

        /// <summary>
        /// Write " > " and read one char from console
        /// </summary>
        /// <param name="isOneChar">If iou want to read only one char write here true, else do not write here any bool</param>
        /// <returns>One char in type of string</returns>
        public static string ConsoleRead(bool isOneChar)
        {
            Console.Write(" > ");
            string ss = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            return ss;
        }

        /// <summary>
        /// Write "s" and read one char from console
        /// </summary>
        /// <param name="s">String wich will bw befor reading from console</param>
        /// <param name="isOneChar">If iou want to read only one char write here true, else do not write here any bool</param>
        /// <returns>>One char in type of string</returns>
        public static string ConsoleRead(string s, bool isOneChar)
        {
            Console.Write(s);
            string ss = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            return ss;
        }
    }
}
