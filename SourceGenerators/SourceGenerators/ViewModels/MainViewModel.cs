
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace SourceGenerators.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        private string _firstName;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        private string _lastName;

        public string FullName => $"{FirstName} {LastName}";

        [ObservableProperty]
        private int _count;

        [ICommand]
        private void ClickMe()
        {
            Count++;
        }
    }
}
