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
    
    public class MainPageViewModel:INotifyPropertyChanged
    {
        #region Fields
        private bool tabisVisible;//הסתרת הטאב הנוכחי
        #endregion

        #region Properties
        public bool IsVisible
        {
          get => tabisVisible;
          set { if (tabisVisible != value) 
                {
                    tabisVisible = value; OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Commands
        public ICommand ClickCommand { get; protected set; }
        #endregion

        #region Constructor
        public MainPageViewModel()
        {
            #region Display Tab By Default
            IsVisible = true;//ברירת המחדל מוצג
            #endregion
            
            //כאשר לוחצים על הכפתור
            ClickCommand = new Command(
                                        () =>
                                        {
                                            #region Hide Tab
                                            IsVisible = false;//הטאב יוסתר
                                            #endregion

                                            #region Return to Shell Main Tab without the current Tab
                                            Shell.Current.GoToAsync("..");//החזרה לדף הבית
                                            #endregion
                                        });
        }
        #endregion

        #region INOTIFYPROPERTYCHANGE EVENT
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
