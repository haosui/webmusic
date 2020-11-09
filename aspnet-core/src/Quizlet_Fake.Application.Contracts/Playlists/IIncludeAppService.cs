using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Quizlet_Fake.Playlists
{
    public interface IIncludeAppService:
        ICrudAppService< //Defines CRUD methods
            IncludeDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateIncludeDto> //Used to create/update a book
    {

    }
    
}
