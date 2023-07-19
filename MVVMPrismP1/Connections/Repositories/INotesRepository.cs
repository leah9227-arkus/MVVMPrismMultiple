using MVVMPrismP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrismP1.Connections.Repositories
{
    public interface INotesRepository
    {
        Task<List<NotesModel>> ListNotes();
        Task<NotesModel> GetNote(int id);
        Task<bool> InsertNote(NotesModel note);
        Task<bool> UpdateNote(NotesModel note);
        Task<bool> DeleteNote(NotesModel note);
    }
}
