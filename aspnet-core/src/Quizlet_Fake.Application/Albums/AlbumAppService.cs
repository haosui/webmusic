using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Quizlet_Fake.Albums
{
    public class AlbumAppService : CrudAppService<
           Album, //The Book entity
           AlbumDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateAlbumDto>, //Used to create/update a book
       IAlbumAppService //implement the IBookAppService
    {
        public AlbumAppService(IRepository<Album, Guid> repository)
            : base(repository)
        {


            this._repository = repository;
        }
        private readonly IRepository<Album, Guid> _repository;
    }
}
    