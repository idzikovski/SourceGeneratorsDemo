using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SourceGenerators.Views;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace SourceGenerators.ViewModels
{
    public partial class LoginViewModel : ObservableValidator
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(UsernameNotValid))]
        [Required]
        [EmailAddress]
        private string _username;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(PasswordNotValid))]
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        private string _password;

        public bool UsernameNotValid => GetErrors(nameof(Username)).Any();

        public bool PasswordNotValid => GetErrors(nameof(Password)).Any();

        [ICommand]
        private async void Login(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
