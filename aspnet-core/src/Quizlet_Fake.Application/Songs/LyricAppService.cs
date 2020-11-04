using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Quizlet_Fake.Songs
{
    public class LyricAppService :
        CrudAppService<
           Lyric, //The Book entity
           LyricDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateLyricDto>, //Used to create/update a book
       ILyricAppService //implement the IBookAppService
    {
        public LyricAppService(IRepository<Lyric, Guid> repository)
            : base(repository)
        {

        }
    }
    
}
