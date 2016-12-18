using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using SoundBoard.Model;
using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Media.Imaging;
using System.Linq;
using Windows.Security.Cryptography.Core;
using Windows.UI.Popups;
using SoundBoard.Classes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SoundBoard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Sound> Sounds;
        private List<String> Suggestions;
        private List<MenuItem> MenuItems;

        private Menu naide = new Menu();
        public MainPage()
        {
            this.InitializeComponent();
            Sounds = new ObservableCollection<Sound>();
            SoundManager.GetAllSounds(Sounds);
            MenuItems = naide.MenuPictures();// pöördume lehe Näide poole ... mine otsi seal koodi edasi.
            BackButton.Visibility = Visibility.Collapsed;
        }

       /* private void Yldine_Click(object sender, RoutedEventArgs e)
        {
            var a = sender as Button;
            if (a.Name == "Nupp")
                Frame.
            MessageDialog msg = new MessageDialog(a.Name);
            msg.ShowAsync();
        }

    */

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            goBack();
        }

        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (String.IsNullOrEmpty(sender.Text)) goBack();

            SoundManager.GetAllSounds(Sounds);
            //Suggestions = Sounds
            //    .Where(p => p.Name.StartsWith(sender.Text))
            //    .Select(p => p.Name)
            //    .ToList();
            SearchAutoSuggestBox.ItemsSource = Paringud.GetSuggestions(Sounds,sender.Text);

        }
        
        private void goBack()
        {
            SoundManager.GetAllSounds(Sounds);
            CategoryTextBlock.Text = "All Sounds";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility= Visibility.Collapsed;
        }


        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            SoundManager.GetSoundsByName(Sounds,sender.Text);
            CategoryTextBlock.Text = sender.Text;
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Visible;
          
        }
   

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {          
            var menuItem = (MenuItem) e.ClickedItem; // Filter on category

            CategoryTextBlock.Text = menuItem.Category.ToString();
            SoundManager.GetSoundsByCategory(Sounds, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sound = (Sound) e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, sound.AudioFile);
        }


        private async void SoundGridView_Drop(object sender, DragEventArgs e)
        {
            if (e.DataView.Contains(StandardDataFormats.StorageItems))
            {
                var items = await e.DataView.GetStorageItemsAsync(); // get references to all the items 

                if (items.Any())
                {
                    var storageFile = items[0] as StorageFile; //give me the first item
                    var contentType = storageFile.ContentType;

                    StorageFolder folder = ApplicationData.Current.LocalFolder;

                    if (contentType == "audio/wav" || contentType == "audio/mpeg")
                    {
                        StorageFile newFile = await
                                storageFile.CopyAsync(folder, storageFile.Name, NameCollisionOption.GenerateUniqueName);

                        MyMediaElement.SetSource(await storageFile.OpenAsync(FileAccessMode.Read), contentType);
                        MyMediaElement.Play();
                    }
                }
            }
        }


        private void SoundGridView_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
            e.DragUIOverride.Caption = "drop to create a custom sound and tile";
            e.DragUIOverride.IsCaptionVisible = true;
            e.DragUIOverride.IsContentVisible = true;
            e.DragUIOverride.IsGlyphVisible = true;
        }

        private void Nupp2_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
