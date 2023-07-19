using MVVMPrismP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrismP1.Connections.Repositories
{
    public class NotesRepository : INotesRepository
    {
        public async Task<bool> DeleteNote(NotesModel note)
        {
            await Task.Run(() => { });
            return true;
        }

        public async Task<NotesModel> GetNote(int id)
        {
            await Task.Run(() => { });

            return new NotesModel()
            {
                Id = id,
                Content = "Harcoded content",
                Title = "Harcoded title"
            };
        }

        public async Task<bool> InsertNote(NotesModel note)
        {
            await Task.Run(() => { });

            return true;
        }

        public async Task<List<NotesModel>> ListNotes()
        {
            await Task.Run(() => { });

            return new List<NotesModel>()
            {
                new NotesModel()
                {
                    Id = 1,
                    Content = "Harcoded content 1",
                    Title = "Harcoded title 1"
                },
                new NotesModel()
                {
                    Id = 2,
                    Content = "Harcoded content 2",
                    Title = "Harcoded title 2"
                }
            };
        }

        public async Task<bool> UpdateNote(NotesModel note)
        {
            await Task.Run(() => { });

            return true;
        }
    }
}
