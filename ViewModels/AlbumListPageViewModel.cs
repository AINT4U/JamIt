using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using Jam_It_.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Jam_It_.Models;
using System.Collections.ObjectModel;
using Jam_It_.Services;

namespace Jam_It_.ViewModels
{

  

    public partial class AlbumListPageViewModel : ObservableObject
    {
        public ObservableCollection<AlbumModel> Albums { get; set; } = new ObservableCollection<AlbumModel>();

        private readonly IAlbumService _albumService;
        public AlbumListPageViewModel(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [ICommand]
        public async void GetAlbumList()
        {
            var albumList = await _albumService.GetAlbumList();
            if(albumList?.Count > 0)
            {
                Albums.Clear();

                foreach (var album in albumList)
                {
                    if(!Albums.Contains(album))
                    {
                        Albums.Add(album);
                    }
                }
            }
        }


        [ICommand]
        public async void AddUpdateAlbum()
        {
            await JamIT.AppShell.Current.GoToAsync(nameof(AddUpdateAlbumDetail));
        }

        [ICommand]
        public async void DisplayAction(AlbumModel album)
        {
            var response = await JamIT.AppShell.Current.DisplayActionSheet("Select Option", "OK", null, "Edit", "Delete");
            if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>();
                navParam.Add("AlbumDetail", album);
                await JamIT.AppShell.Current.GoToAsync(nameof(AddUpdateAlbumDetail), navParam);
            }
            else if(response == "Delete")
            {
                var delResponse =await _albumService.DeleteAlbum(album);
                if(delResponse > 0)
                {
                    GetAlbumList();
                }

            }
        }

    }
}
