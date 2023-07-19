using MVVMPrismP1.Connections.Repositories;
using MVVMPrismP1.Events;
using Prism.Events;
using Prism.Mvvm;

namespace MVVMPrismP1.ViewModels
{
    public class NotesViewModel : BindableBase
    {
        private readonly INotesRepository _notesRepository;
        private string _message = "No message.";
        public string Message {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public NotesViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<RandonDocumentCreated>().Subscribe(RandonDocumentCreatedEvent);
            _notesRepository = new NotesRepository();
        }

        private async void RandonDocumentCreatedEvent(string message)
        {
            Message = message;
            var note = await _notesRepository.GetNote(1);
        }
    }
}
