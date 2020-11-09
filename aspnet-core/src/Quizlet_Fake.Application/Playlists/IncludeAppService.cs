using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace Quizlet_Fake.Playlists
{
    public class IncludeAppService : CrudAppService<
           Include, //The Book entity
           IncludeDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateIncludeDto>, //Used to create/update a book
       IIncludeAppService //implement the IBookAppService
    {
        public IncludeAppService(IRepository<Include, Guid> repository, ICurrentUser currentUser)
            : base(repository)
        {

            this._repository = repository;
            this._currentUser = currentUser;
        }
        private readonly IRepository<Include, Guid> _repository;
        private readonly ICurrentUser _currentUser;
    }

}
