using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.SpotifyClone.Views.Components;

public partial class Playlist : UserControl
{
    public Playlist()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public void ChangeImage(Avalonia.Media.IImage newImage)
    {

        PlaylistImage.Source = newImage;
    }

    public void ChangeName(string newText)
    {
        PlaylistName.Text = newText;
    }
}