using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4 PREIM
public class Note
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; private set; }

    public Note(string title, string text)
    {
        Title = title;
        Text = text;
        Date = DateTime.Now;
    }
}

public class Notebook
{
    public string Author { get; private set; }
    public List<Note> Notes;

    public Notebook(string author)
    {
        Author = author;
        Notes = new List<Note>();
    }

    public void AddNote(Note note)
    {
        Notes.Add(note);
    }
}
