using System;
using System.Collections.Generic;
using System.Text;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Quizlet_Fake.Tags
{
    public class SongTagAppService: CrudAppService<
           SongTag, //The Book entity
           SongTagDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateSongTagDto>, //Used to create/update a book
       ISongTagAppService //implement the IBookAppService
    {
        public SongTagAppService(IRepository<SongTag, Guid> repository)
            : base(repository)
        {

        }
    }
    
}
