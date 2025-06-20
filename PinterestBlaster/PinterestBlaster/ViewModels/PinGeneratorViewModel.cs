using System.Collections.ObjectModel;
using PinterestBlaster.Helpers;
using PinterestBlaster.Models;
using System.ComponentModel;

namespace PinterestBlaster.ViewModels
{
    public class PinGeneratorViewModel : INotifyPropertyChanged
    {
        private string _topic;
        public string Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
                GenerateCommand.RaiseCanExecuteChanged();
            }
        }

        public ObservableCollection<PinContent> Suggestions { get; set; } = new();

        public RelayCommand GenerateCommand { get; }

        public PinGeneratorViewModel()
        {
            GenerateCommand = new RelayCommand(
                o => GenerateIdeas(),
                o => !string.IsNullOrWhiteSpace(Topic)
            );
        }

        private void GenerateIdeas()
        {
            Suggestions.Clear();
            Suggestions.Add(new PinContent
            {
                Title = $"10 {Topic} Ideas You Haven’t Tried Yet",
                Description = $"Discover unique {Topic} ideas backed by real stats and expert tips. “The best way to get started is to begin.”"
            });
            Suggestions.Add(new PinContent
            {
                Title = $"The Ultimate Guide to {Topic} in 2025",
                Description = $"All you need to master {Topic}. Trusted by thousands. “Success leaves clues.”"
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
