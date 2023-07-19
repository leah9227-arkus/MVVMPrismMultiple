using System;
using MVVMPrismP1.Connections.Repositories;
using MVVMPrismP1.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace MVVMPrismP1.ViewModels
{
    public class DocumentsViewModel : BindableBase
    {
        #region Encapsulation
        private IEventAggregator _eventAgregator;
        private readonly IDocumentRepository _documentRepository;

        private int _id = 0;
        public int Id {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _name = "Empty name";
        public string Name {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _description = "ASDASD";
        public string Description {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _isActiveText;
        public string IsActiveText {
            get => _isActiveText;
            set => SetProperty(ref _isActiveText, value);
        }

        private DateTime _creationDate;
        public DateTime CreationDate {
            get => _creationDate;
            set => SetProperty(ref _creationDate, value);
        }
        #endregion

        #region Commands
        public DelegateCommand CreateRandomDocumentCommand { get; set; }
        #endregion

        #region Actions
        private async void CreateRandonDocument()
        {
            var newDocument = await _documentRepository.GetDocument(DateTime.Now.Millisecond);

            Id = newDocument.Id;
            Name = newDocument.Name;
            Description = newDocument.Description;
            CreationDate = newDocument.CreateionDate;
            IsActiveText = newDocument.IsActive ? "Active" : "Inactive";

            _eventAgregator.GetEvent<RandonDocumentCreated>().Publish($"Created user with id: {newDocument.Id}");
        }
        #endregion

        public DocumentsViewModel(IEventAggregator eventAggregator)
        {
            CreateRandomDocumentCommand = new DelegateCommand(CreateRandonDocument);
            _eventAgregator = eventAggregator;
            _documentRepository = new DocumentRepository();
        }
    }
}
