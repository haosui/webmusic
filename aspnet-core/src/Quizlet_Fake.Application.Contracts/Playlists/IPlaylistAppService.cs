using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Quizlet_Fake.Playlists
{
    public interface IPlaylistAppService :
        ICrudAppService< //Defines CRUD methods
            PlaylistDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePlaylistDto> //Used to create/update a book
    {

    }
    
}
