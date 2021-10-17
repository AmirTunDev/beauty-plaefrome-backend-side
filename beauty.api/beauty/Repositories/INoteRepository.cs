using beauty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beauty.Repositories
{
    public interface INoteRepository
    {
        IEnumerable<Note> GetAllNotes();
        Note GetNoteById(int id);
        void Insert(Note note);
        void Update(Note note);
        void Delete(int id);
        


    }
}
