using Jam_It_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jam_It_.Services
{
     public interface IAlbumService
    {
        Task<List<AlbumModel>> GetAlbumList();

        Task<int> AddAlbum(AlbumModel albumModel);
        Task<int> DeleteAlbum(AlbumModel albumModel);

        Task<int> UpdateAlbum(AlbumModel albumModel);
    }
}
