using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Quizlet_Fake.AuthorSingers
{
    public class SongbySingerAppService : CrudAppService<
           SongbySinger, //The Book entity
           SongbySingerDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateSongbySingerDto>, //Used to create/update a book
       ISongbySingerAppService //implement the IBookAppService
    {
        public SongbySingerAppService(IRepository<SongbySinger, Guid> repository)
            : base(repository)
        {

            this._repository = repository;
        }
        private readonly IRepository<SongbySinger, Guid> _repository;

    }
}
