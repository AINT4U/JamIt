using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamIT.Models
{
    class SongModel : INotifyPropertyChanged
    {
        private string songName;
        private double duration;
        public string description;
        public string featurings;
        public string album;
        public string songLink;
        public DateTime releaseDate;
        public Boolean isExplicit;
        public string label;

        public string SongName
        {
            get { return songName; }
            set
            {
                songName = value;
                OnPropertyChanged("SongName");
            }
        }

        public double Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }        
        
        public string Featurings
        {
            get { return featurings; }
            set
            {
                featurings = value;
                OnPropertyChanged("Featurings");
            }
        }

        public string Album
        {
            get { return album; }
            set
            {
                album = value;
                OnPropertyChanged("Album");
            }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                releaseDate = value;
                OnPropertyChanged("ReleaseDate");
            }
        }

        public string SongLink
        {
            get { return songLink; }
            set
            {
                songLink = value;
                OnPropertyChanged("SongLink");
            }
        }

        public Boolean IsExplicit
        {
            get { return isExplicit; }
            set
            {
                isExplicit = value;
                OnPropertyChanged("IsExplicit");
            }
        }

        public String Label
        {
            get { return label; }
            set
            {
                label = value;
                OnPropertyChanged("Label");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
