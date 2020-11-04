using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Quizlet_Fake.Tags
{
    public interface ITagAppService: ICrudAppService< //Defines CRUD methods
            TagDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTagDto> //Used to create/update a book
    {

    }
   
}
