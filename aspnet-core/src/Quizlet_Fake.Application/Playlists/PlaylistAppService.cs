using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Quizlet_Fake.Playlists
{
    public class PlaylistAppService : CrudAppService<
           Playlist, //The Book entity
           PlaylistDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdatePlaylistDto>, //Used to create/update a book
       IPlaylistAppService //implement the IBookAppService
    {
        public PlaylistAppService(IRepository<Playlist, Guid> repository)
            : base(repository)
        {

        }

    }
    
    
}
