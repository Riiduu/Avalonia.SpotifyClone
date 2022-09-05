using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

namespace Avalonia.SpotifyClone.Views.Components;

public partial class RecentPlaylists : UserControl
{
    public RecentPlaylists()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    void ChangeFirst()
    {
        Playlist1.ChangeImage(new Bitmap("../../Assets/playlists/Playlist-2.jpeg"));
        Playlist1.ChangeName("Tavmamm");
    }
}