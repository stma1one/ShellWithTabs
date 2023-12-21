using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShellWithTabs.ViewModels
{
    public class HomePageViewModel:INotifyPropertyChanged
    {
        private bool TabisVisible;
        private bool pageIsVisible;
        public bool IsVisible { get => TabisVisible; set { TabisVisible = value; OnPropertyChanged(); OnPropertyChanged(nameof(PageIsVisible));  } }
        public bool PageIsVisible { get => !TabisVisible;  }

        public ICommand ClickCommand { get; protected set; }
        public HomePageViewModel() { IsVisible = false;
            ClickCommand = new Command(async () => { Shell.Current.DisplayAlert("hi", "hi", "hi"); IsVisible = true; await Shell.Current.GoToAsync(".."); });
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
