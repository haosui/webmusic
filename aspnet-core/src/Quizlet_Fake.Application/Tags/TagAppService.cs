using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;

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

            this._repository = repository;
        }
        private readonly IRepository<Tag, Guid> _repository;

        public async Task<List<TagDto>> getlisttag()
        {
            await CheckGetListPolicyAsync();
            var qr = from tagg in _repository select tagg;
            var queryResult = await AsyncExecuter.ToListAsync(qr);
            var Dtos = queryResult.Select(x =>
           {
               var dto = ObjectMapper.Map<Tag, TagDto>(x);
               return dto;
           }).ToList();
            return new List<TagDto>(Dtos);

        }
    }
    
}
