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
    /// Write to console some text to user
    /// </summary>
    static class Starting
    {
        /// <summary>
        /// Writes startup text
        /// </summary>
        public static void Start()
        {
            Console.WriteLine("Wellcome in notepad");
            Console.WriteLine("To show gude enter here \"?\"");
            Console.WriteLine("============================");
        }

        /// <summary>
        /// Writes help menu
        /// </summary>
        public static void Help()
        {
            Console.WriteLine("============Help============");
            Console.WriteLine("To open help window enter <?>");
            Console.WriteLine("To exit program press \"e\"");
            Console.WriteLine("To endup note press \"e\"");
            Console.WriteLine("To create new note press \"n\"");
            Console.WriteLine("To remove note press \"r\"");
            Console.WriteLine("To show list of notes press \"s\"");
            Console.WriteLine("To open note press\"o\"");
            Console.WriteLine("============================");
        }
    }
}
