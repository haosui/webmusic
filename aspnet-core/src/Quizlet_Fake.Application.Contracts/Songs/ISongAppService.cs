using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Quizlet_Fake.Songs
{
    

    public interface ISongAppService :
        ICrudAppService< //Defines CRUD methods
            SongDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSongDto> //Used to create/update a book
    {

    }
}
