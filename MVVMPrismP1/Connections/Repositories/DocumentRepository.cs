using MVVMPrismP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrismP1.Connections.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        public async Task<bool> DeleteDocument(DocumentModel document)
        {
            await Task.Run(() => { });

            return true;
        }

        public async Task<DocumentModel> GetDocument(int id)
        {
            await Task.Run(() => { });

            return new DocumentModel()
            {
                Id = id,
                CreateionDate = new DateTime(),
                Description = "Description harcoded",
                IsActive = true,
                Name = "Document name harcoded"
            };
        }

        public async Task<bool> InsertDocument(DocumentModel document)
        {
            await Task.Run(() => { });

            return true;
        }

        public async Task<List<DocumentModel>> ListDocuments()
        {
            await Task.Run(() => { });

            return new List<DocumentModel>()
            {
                new DocumentModel()
                {
                    Id = 1,
                    CreateionDate = new DateTime(),
                    Description = "Description harcoded 1",
                    IsActive = true,
                    Name = "Document name harcoded 1"
                },
                new DocumentModel()
                {
                    Id = 2,
                    CreateionDate = new DateTime(),
                    Description = "Description harcoded 2",
                    IsActive = true,
                    Name = "Document name harcoded 2"
                }
            };
        }

        public async Task<bool> UpdateDocument(DocumentModel document)
        {
            await Task.Run(() => { });

            return true;
        }
    }
}
