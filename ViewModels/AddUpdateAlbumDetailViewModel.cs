using Jam_It_.Models;
using Jam_It_.Services;
using Jam_It_.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jam_It_.ViewModels
{
    [QueryProperty(nameof(AlbumDetail), "AlbumDetail")]
    public partial class AddUpdateAlbumDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private AlbumModel _albumDetail = new AlbumModel();

        public readonly IAlbumService _albumService;
        public AddUpdateAlbumDetailViewModel(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [ICommand]
        public async void AddUpdateAlbum()
        {
            int response = -1;

            if(AlbumDetail.Id > 0)
            {
                response = await _albumService.UpdateAlbum(AlbumDetail);
            }
            else { 
                response = await _albumService.AddAlbum(new Models.AlbumModel
                {
                    Name = AlbumDetail.Name,
                    ReleaseDate=AlbumDetail.ReleaseDate,
                    //Songs = _songs
                }) ;
            }

            if (response > 0)
            {
                await Shell.Current.GoToAsync("//AlbumOverview");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not Created", "Something went wrong while creating", "OK");

            }
        }
    }
}
