using System;
using System.Collections.Generic;
using Jam_It_.Models;
using SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jam_It_.Services
{
    public class AlbumService : IAlbumService
    {
        private SQLiteAsyncConnection _dbConnection;
        public AlbumService() {
            if(_dbConnection == null)
            {
                SetUpDb();
            }
        }

        private async void SetUpDb()
        {
            if(_dbConnection == null)
            {
             string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "jam_it.db3");
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<AlbumModel>();

            }
        

        }

        public Task<int> AddAlbum(AlbumModel albumModel)
        {
            return _dbConnection.InsertAsync(albumModel);
        }

        public Task<int> DeleteAlbum(AlbumModel albumModel)
        {
            return _dbConnection.DeleteAsync(albumModel);
        }

        public async Task<List<AlbumModel>> GetAlbumList()
        {
            var albumList = await _dbConnection.Table<AlbumModel>().ToListAsync();
            return albumList;
        }

        public Task<int> UpdateAlbum(AlbumModel albumModel)
        {
            return _dbConnection.UpdateAsync(albumModel);

        }
    }
}
