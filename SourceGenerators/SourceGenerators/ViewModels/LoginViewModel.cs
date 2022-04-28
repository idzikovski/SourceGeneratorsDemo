//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
using SourceGenerators.Views;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace SourceGenerators.ViewModels
{
    public partial class LoginViewModel //: ObservableObject
    {
        //[ObservableProperty]
        //[AlsoNotifyChangeFor(nameof(UsernameNotValid))]
        //private string _username;

        //[ObservableProperty]
        //[AlsoNotifyChangeFor(nameof(PasswordNotValid))]
        //private string _password;

        //public bool UsernameNotValid => Username != null && !UsernameIsValid();

        //public bool PasswordNotValid => Password != null && !PasswordIsValid();

        //[ICommand]
        //private async void Login(object obj)
        //{
        //    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        //}

        //private bool UsernameIsValid()
        //{
        //    if (string.IsNullOrEmpty(Username))
        //    {
        //        return false;
        //    }

        //    Regex regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
        //    Match match = regex.Match(Username);
        //    return match.Success;
        //}

        //private bool PasswordIsValid()
        //{
        //    if (string.IsNullOrEmpty(Password))
        //    {
        //        return false;
        //    }

        //    return (Password.Length > 3 && Password.Length < 11);
        //}
    }
}
