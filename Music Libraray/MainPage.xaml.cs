using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Music_Libraray
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

       

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            await SetLocalMedia();



        }
        async private System.Threading.Tasks.Task SetLocalMedia()
        {
            var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

            openPicker.FileTypeFilter.Add(".wmv");
            openPicker.FileTypeFilter.Add(".mp4");
            openPicker.FileTypeFilter.Add(".wma");
            openPicker.FileTypeFilter.Add(".mp3");

            var file = await openPicker.PickSingleFileAsync();

            // mediaPlayer is a MediaPlayerElement defined in XAML
            if (file != null)
            {
                mediaPlayer.Source = MediaSource.CreateFromStorageFile(file);

                mediaPlayer.MediaPlayer.Play();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer.MediaPlayer.Pause();
        }

        private void ComboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void ComboBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = ComboBox1.SelectedIndex;


            switch (selectedIndex)
            {
                case 1:
                   IStorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("C:\\Users\by_ma\\Desktop\\Music\\english\\MissionImpossibleFalloutTheme.mp3"));
                    //var file= "C:\\Users\by_ma\\Desktop\\Music\\english\\MissionImpossibleFalloutTheme.mp3";
                    mediaPlayer.Source= MediaSource.CreateFromStorageFile(file);

                    mediaPlayer.MediaPlayer.Play();
                    break;
               /* case 1:
                    StorageFile file1 = await StorageFile.GetFileFromApplicationUriAsync(new Uri("C:\\Users\by_ma\\Desktop\\Music\\english\\MissionImpossibleFalloutTheme.mp3"));
                    //var file= "C:\\Users\by_ma\\Desktop\\Music\\english\\MissionImpossibleFalloutTheme.mp3";
                    mediaPlayer.Source = MediaSource.CreateFromStorageFile(file1);

                    mediaPlayer.MediaPlayer.Play();
                    break;
                    */

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
