using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jam_It_.Models
{
    
    public class AlbumModel
    {
        // private List<SongModel> songs;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public String ArtistName { get; set; }

        //public List<SongModel> Songs { get; set; }
    }
}
