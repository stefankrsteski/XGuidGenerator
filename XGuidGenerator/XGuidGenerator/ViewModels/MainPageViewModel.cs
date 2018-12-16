using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XGuidGenerator.Interfaces;

namespace XGuidGenerator.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private Guid _guid;
        public Guid Guid
        {
            get
            {
                return _guid;
            }
            set
            {
                if (value != _guid)
                {
                    _guid = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICommand GenerateGuid => new Command(async ()=>
        {
            Guid = Guid.NewGuid();
            //DependencyService.Get<IClipboard>().CopyToClipboard(Guid.ToString());
            await Clipboard.SetTextAsync(Guid.ToString());
            DependencyService.Get<IToast>().Show($"{Guid.ToString()} is copied to clipboard!");
        });

        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
