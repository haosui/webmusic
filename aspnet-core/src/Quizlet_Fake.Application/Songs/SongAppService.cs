using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Quizlet_Fake.Songs
{
    public class BookAppService :
       CrudAppService<
           Song, //The Book entity
           SongDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateSongDto>, //Used to create/update a book
       ISongAppService //implement the IBookAppService
    {
        public BookAppService(IRepository<Song, Guid> repository)
            : base(repository)
        {

        }
    }
}
