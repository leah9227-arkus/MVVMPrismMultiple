using MVVMPrismP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrismP1.Connections.Repositories
{
    public interface IDocumentRepository
    {
        Task<List<DocumentModel>> ListDocuments();
        Task<DocumentModel> GetDocument(int id);
        Task<bool> InsertDocument(DocumentModel document);
        Task<bool> UpdateDocument(DocumentModel document);
        Task<bool> DeleteDocument(DocumentModel document);
    }
}
