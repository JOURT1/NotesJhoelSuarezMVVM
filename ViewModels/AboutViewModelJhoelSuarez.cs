using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Notes.ViewModels;

internal class AboutViewModel
{
    public string TitleJHOELS => "Jhoel Suarez";
    public string VersionJHOELS => AppInfo.VersionString;
    public string MoreInfoUrlJHOELS => "https://aka.ms/maui";
    public string MessageJHOELS => "Tengo 20 años, soy estudiante de Ingeniería de Software cursando el quinto semestre. Me gustan los deportes, en especial entrenar en el gimnasio, los carros y las motos.";
    public ICommand ShowMoreInfoCommandJHOELS { get; }

    public AboutViewModel()
    {
        ShowMoreInfoCommandJHOELS = new AsyncRelayCommand(ShowMoreInfo);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrlJHOELS);
}