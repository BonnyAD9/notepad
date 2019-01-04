using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mine
using ConsoleNotepad;

namespace ConsoleNotepad
{
    class Program
    {
        /* For testing 
        static void Main(string[] args)
        {
        }*/

        /* Program - only use for complete function */
        static void Main(string[] args)
        {
            Notepad notepad = new Notepad();
            string data = "data.json";
            if (!BaseActions.JsonFile(data))
                notepad = BaseActions.LoadFromJson(data);
            else
            {
                Environment.Exit(1);
            }
            Starting.Start();
            notepad = BaseActions.ConsoleCycle(notepad);
            BaseActions.SaveToJson(notepad, data);
        }
    }
}
