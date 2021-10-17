using beauty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Data;
using Microsoft.EntityFrameworkCore;

namespace beauty.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly beautyContext _beautyContext;
        public NoteRepository(beautyContext beautyContext)
        {
            _beautyContext = beautyContext;
        }
        public void Delete(int id)
        {
            Note note = _beautyContext.Note.Find(id);

            note.Active = true;

        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _beautyContext.Note.ToList();
        }

        public Note GetNoteById(int id)
        {
            return _beautyContext.Note.Find(id);
        }

        public void Insert(Note note)
        {
            _beautyContext.Note.Add(note);
        }



        public void Update(Note note)
        {
            _beautyContext.Entry(note).State = EntityState.Modified;
        }
    }
}
