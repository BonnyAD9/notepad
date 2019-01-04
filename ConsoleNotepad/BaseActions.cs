using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Unused
using System.IO;
// Added
using System.Web.Script.Serialization;
// Mine
using ConsoleNotepad;

namespace ConsoleNotepad
{
    /// <summary>
    /// Class include some of important basic action created for this program
    /// </summary>
    class BaseActions
    {

        /// <summary>
        /// The main cycle of program
        /// </summary>
        /// <param name="notepad">Notepad from wich will be taken data</param>
        /// <returns>Notepad in wich will be data</returns>
        public static Notepad ConsoleCycle(Notepad notepad)
        {
            if (notepad == null)
                notepad = new Notepad();
            bool b = true;
            while (b)
            {
                string s = ComSets.ConsoleRead(true);
                switch (s)
                {
                    case "?":
                        Starting.Help();
                        break;

                    case "e":
                        b = false;
                        break;

                    case "<e>":
                        b = false;
                        break;

                    case "n":
                        bool bb = true;
                        Note note = new Note();
                        Console.WriteLine("============================");
                        Console.Write("Write here title of your note: ");
                        note.Title = Console.ReadLine();
                        while (bb)
                        {
                            string sn = Console.ReadLine();
                            if (sn == "e")
                            {
                                bb = false;
                                Console.WriteLine("============================");
                            }
                            else
                                note.Text.Add(sn);
                        }
                        if (!notepad.AddNote(note))
                            Console.WriteLine("This note is already existing or you enter empty Title.");
                        break;

                    case "r":
                        Console.WriteLine("============================");
                        Console.Write("Write here title of your note: ");
                        string sr = Console.ReadLine();
                        if (!notepad.RemoveNote(notepad.Notes.Find(p => p.Title == sr)))
                            Console.WriteLine("This note doesn't exist.");
                        break;

                    case "s":
                        Console.WriteLine("============================");
                        notepad.Notes.ForEach(p => Console.Write($"{p.Title}\n"));
                        Console.WriteLine("============================");
                        break;

                    case "o":
                        Console.WriteLine("============================");
                        Console.Write("Write here title of your note: ");
                        string so = Console.ReadLine();
                        if (!notepad.WriteNote(so))
                            Console.WriteLine("This note doesn't exist.");
                        Console.WriteLine("============================");
                        break;

                    default:
                        break;
                }
            }
            return notepad;
        }
        
        /// <summary>
        /// If not exist json file in "path" path create one there
        /// </summary>
        /// <param name="path">Path where has to be json file</param>
        /// <returns>Return true if path was created, false if parh already exist</returns>
        public static bool JsonFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Serilize all data from notepad to path
        /// </summary>
        /// <param name="notepad">notepad wich you want to serilize</param>
        /// <param name="path">parh where will be json file saved</param>
        public static bool SaveToJson(Notepad notepad, string path)
        {
            bool b = false;
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string s = jss.Serialize(notepad.GetList());
            try
            {
                File.WriteAllText(path, s);
            }
            finally { }
            b = true;
            return b;
        }

        /// <summary>
        /// Deserilize all data from "path" path
        /// </summary>
        /// <param name="path">Path to json file</param>
        /// <returns>Notepad with data from json file in path</returns>
        public static Notepad LoadFromJson(string path)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            Notepad notepad = new Notepad();
            string s = File.ReadAllText(path);
            notepad.Notes = jss.Deserialize<List<Note>>(s);
            return notepad;
        }
    }
}
