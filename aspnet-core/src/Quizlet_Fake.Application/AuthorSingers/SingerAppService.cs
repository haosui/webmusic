using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Quizlet_Fake.AuthorSingers
{
    public class SingerAppService : CrudAppService<
           Singer, //The Book entity
           SingerDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateSingerDto>, //Used to create/update a book
       ISingerAppService //implement the IBookAppService
    {
        public SingerAppService(IRepository<Singer, Guid> repository)
            : base(repository)
        {

        }
    
    }
}
