using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Quizlet_Fake.AuthorSingers
{
    public interface ISongbySingerAppService
        : ICrudAppService< //Defines CRUD methods
            SongbySingerDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSongbySingerDto>
    {

    }
}
