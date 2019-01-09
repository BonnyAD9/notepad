using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mine
using ConsoleNotepad;

namespace ConsoleNotepad
{
    class Notepad
    {
        /// <summary>
        /// Include all notes
        /// </summary>
        public List<Note> Notes = new List<Note>();

        /// <summary>
        /// Return notes in your Notepad
        /// </summary>
        /// <returns>List Note from Notepad</returns>
        public List<Note> GetList()
        {
            return Notes;
        }

        /// <summary>
        /// Add note to Notes (List of Note)
        /// </summary>
        /// <param name="note">Some note of type Note in this same namespace</param>
        /// <returns>true if note not exist in Notes, false if Title of note is already existing in Notes</returns>
        public bool AddNote(Note note)
        {
            if (Notes.Exists(p => p.Title == note.Title) && (note.Title != ""))
            {
                return false;
            }
            else
            {
                Notes.Add(note);
                return true;
            }
        }

        /// <summary>
        /// Removes note from Notes (List of Note)
        /// </summary>
        /// <param name="note">Some note of type Note</param>
        /// <returns>true if note exist in Notes and is deleted, false if note Title does not exist in Notes</returns>
        public bool RemoveNote(Note note)
        {
            if (note != null)
            {
                if (Notes.Exists(p => p.Title == note.Title))
                {
                    Notes.Remove(Notes.Find(p => p.Title == note.Title));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }

        /// <summary>
        /// Removes note from Notes (List of Note)
        /// </summary>
        /// <param name="s">Title of note if type string</param>
        /// <returns>true if name note exist in Notes and is note deleted, false if Title does not exist in Notes</returns>
        public bool RemoveNote(string s)
        {
            if (Notes.Exists(p => p.Title == s))
            {
                Notes.Remove(Notes.Find(p => p.Title == s));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool WriteNote(string s)
        {
            if (Notes.Exists(p => p.Title == s))
            {
                Console.WriteLine(Notes.Find(p => p.Title == s).Title);
                foreach (string ss in Notes.Find(p => p.Title == s).Text)
                    Console.WriteLine(ss);
                return true;
            }
            else
                return false;
        }
    }

    /// <summary>
    /// Class for saving notes as data type
    /// </summary>
    class Note
    {
        /// <summary>
        /// For saving title of note
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// For saving note in list of string for each line
        /// </summary>
        public List<string> Text { get; set; } = new List<string>();
    }
}
