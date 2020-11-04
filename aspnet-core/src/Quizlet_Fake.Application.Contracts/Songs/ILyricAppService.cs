using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Quizlet_Fake.Songs
{
    public interface ILyricAppService: ICrudAppService< //Defines CRUD methods
            LyricDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateLyricDto> //Used to create/update a book
    {

    }
    
}
