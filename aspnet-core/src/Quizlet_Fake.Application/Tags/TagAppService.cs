using System;
using System.Collections.Generic;
using System.Text;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Quizlet_Fake.Tags
{
    public class TagAppService: CrudAppService<
           Tag, //The Book entity
           TagDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateTagDto>, //Used to create/update a book
       ITagAppService //implement the IBookAppService
    {
        public TagAppService(IRepository<Tag, Guid> repository)
            : base(repository)
    {

    }
}
    
}
