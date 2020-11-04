using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Quizlet_Fake.AuthorSingers
{
    public class AuthorAppService : CrudAppService<
            Author, //The Book entity
            AuthorDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAuthorDto>, //Used to create/update a book
        IAuthorAppService //implement the IBookAppService
    {
        public AuthorAppService(IRepository<Author, Guid> repository)
            : base(repository)
        {

        }

    }
}
