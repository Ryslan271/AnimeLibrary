﻿using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Wpf.Ui.Controls;
using System.Collections.ObjectModel;
using MessageBox = System.Windows.MessageBox;
using AnimeAX.Models.DataBase;

namespace AnimeAX.View.ForAdmin.Windows
{
    public partial class EditAnime : UiWindow
    {
        public EditAnime(Anime anime)
        {
            CurrentAnime = anime;

            AnimeGenres = new ObservableCollection<AnimeGenre>(App.Db.AnimeGenre.Local.Where(g => CurrentAnime.AnimeGenre_Anime.FirstOrDefault(a => a.AnimeGenre == g) == null));
            AnimeStatuses = App.Db.AnimeStatus.Local;
            AnimeTypes = App.Db.AnimeType.Local;

            CurrentAnimeGenres = new ObservableCollection<AnimeGenre>(CurrentAnime.AnimeGenre_Anime.Select(a => a.AnimeGenre));

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "mp4 files (*.mp4)|*.mp4",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == false)
                return;

            byte[] video_bytes = File.ReadAllBytes(openFileDialog.FileName); // получаем байты выбранного файла

            CurrentAnime.FileBit = video_bytes;

            mePlayer.Source = new Uri(openFileDialog.FileName);
        }

        private void ComboBoxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxGenre == null)
                return;

            if (ComboBoxGenre.SelectedItem == null)
                return;

            if (CurrentAnimeGenres == null)
                CurrentAnimeGenres = new ObservableCollection<AnimeGenre>();

            CurrentAnimeGenres.Add(ComboBoxGenre.SelectedItem as AnimeGenre);
            AnimeGenres.Remove(ComboBoxGenre.SelectedItem as AnimeGenre);
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AnimeGenres.Add(ComboBoxGenre.SelectedItem as AnimeGenre);
            CurrentAnimeGenres.Remove(ComboBoxGenre.SelectedItem as AnimeGenre);
        }

        private void PauseMePlayer(object sender, RoutedEventArgs e)
            => mePlayer.Pause();

        private void PlayMeplayer(object sender, RoutedEventArgs e)
            => mePlayer.Play();

        private void EditPhoto(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "png files (*.png)|*.png",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == false)
                return;

            byte[] image_bytes = File.ReadAllBytes(openFileDialog.FileName); // получаем байты выбранного файла

            CurrentAnime.Image = image_bytes;

            BitmapImage bitmap = new BitmapImage();

            // Загрузите изображение из байт-массива в BitmapImage
            using (MemoryStream memStream = new MemoryStream(image_bytes))
            {
                memStream.Position = 0;
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = memStream;
                bitmap.EndInit();
            }

            AnimePhoto.Source = bitmap;
        }

        private void Saving(object sender, RoutedEventArgs e)
        {
            foreach (var genre in CurrentAnimeGenres)
            {
                if (CurrentAnime.AnimeGenre_Anime.Select(a => a.AnimeGenre).Contains(genre) == true)
                    continue;

                if (CurrentAnime.AnimeGenre_Anime.FirstOrDefault(g => g.AnimeGenre == genre) != null)
                    continue;

                App.Db.AnimeGenre_Anime.Add
                    (
                        new AnimeGenre_Anime
                        {
                            Anime = CurrentAnime,
                            AnimeGenre = genre
                        }
                    );
            }


            App.Db.SaveChanges();
            MessageBox.Show("Данные сохранены");

        }
    }
}