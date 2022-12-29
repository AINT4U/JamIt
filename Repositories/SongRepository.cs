using JamIT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamIT.Repositories
{
    class SongRepository
    {
        private ObservableCollection<SongModel> songs;

        public ObservableCollection<SongModel> Songs
        {
            get { return songs; }
            set { this.songs = value; }
        }

        public SongRepository()
        {
            GenerateSongs();
        }

        internal void GenerateSongs()
        {
            songs = new ObservableCollection<SongModel>();
            songs.Add(new SongModel()
            {
                SongName = "Song 1",
                Description = "",
                Featurings = "",
                isExplicit = true,
                Label = "Griselda Records",
                Duration = 2.5,
                releaseDate = DateTime.Now,
                Album = "Album 1",
                SongLink = "www.google.com"
            });

            songs.Add(new SongModel()
            {
                SongName = "Song 2",
                Description = "",
                Featurings = "",
                isExplicit = true,
                Label = "Griselda Records",
                Duration = 3,
                releaseDate = DateTime.Now,
                Album = "Album 1",
                SongLink = "www.google.com"
            });

            songs.Add(new SongModel()
            {
                SongName = "Song 3",
                Description = "",
                Featurings = "Wiz Khalifa",
                isExplicit = true,
                Label = "Griselda Records",
                Duration = 3.2,
                releaseDate = DateTime.Now,
                Album = "Album 1",
                SongLink = "www.google.com"
            });

            songs.Add(new SongModel()
            {
                SongName = "Song 4",
                Description = "",
                Featurings = "Joey Bada$$",
                isExplicit = true,
                Label = "Griselda Records",
                Duration = 4.6,
                releaseDate = DateTime.Now,
                Album = "Album 1",
                SongLink = "www.google.com"
            });

            songs.Add(new SongModel()
            {
                SongName = "Song 5",
                Description = "",
                Featurings = "",
                isExplicit = true,
                Label = "Griselda Records",
                Duration = 2,
                releaseDate = DateTime.Now,
                Album = "Album 1",
                SongLink = "www.google.com"
            });

            songs.Add(new SongModel()
            {
                SongName = "Song 6",
                Description = "",
                Featurings = "",
                isExplicit = true,
                Label = "Griselda Records",
                Duration = 4.2,
                releaseDate = DateTime.Now,
                Album = "Album 1",
                SongLink = "www.google.com"
            });

            songs.Add(new SongModel()
            {
                SongName = "Song 7",
                Description = "Westside Gunn, Benny the Butcher",
                Featurings = "",
                isExplicit = true,
                Label = "Griselda Records",
                Duration = 5.2,
                releaseDate = DateTime.Now,
                Album = "Album 1",
                SongLink = "www.google.com"
            });

        }
    }
}
