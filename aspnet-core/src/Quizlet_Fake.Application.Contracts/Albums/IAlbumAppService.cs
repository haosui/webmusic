using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Quizlet_Fake.Albums
{
    public interface IAlbumAppService : ICrudAppService< //Defines CRUD methods
            AlbumDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAlbumDto> //Used to create/update a book
    {

    }
   
}
