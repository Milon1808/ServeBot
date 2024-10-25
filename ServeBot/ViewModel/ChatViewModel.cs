using ServeBot.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ServeBot.ViewModel
{
    public class ChatViewModel : BaseViewModel
    {
        // Liste der Nachrichten
        public ObservableCollection<ServeKI> ServeMessages { get; set; }
        public string UserInput { get; set; }
        public ICommand SendMessageCommand { get; }

        public ChatViewModel()
        {
            // Initialisierung der Nachrichtenliste
            ServeMessages = new ObservableCollection<ServeKI>();
            // Initialisierung des Commands
            SendMessageCommand = new RelayCommand(SendMessage);
        }

        // Methode, die beim Senden aufgerufen wird
        private void SendMessage()
        {
            // Fügt die Benutzer-Nachricht hinzu (rechtsbündig)
            ServeMessages.Add(new ServeKI { Sender = "Du", Text = UserInput });

            // KI-Antwort generieren (linksbündig)
            var response = "Hallo! Ich bin deine KI-Begleitung!";
            ServeMessages.Add(new ServeKI { Sender = "KI", Text = response });

            // Eingabefeld leeren
            UserInput = string.Empty;

            
        }
    }
}
