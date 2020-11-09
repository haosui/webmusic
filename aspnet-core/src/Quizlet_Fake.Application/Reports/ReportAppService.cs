using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace Quizlet_Fake.Reports
{
    public class ReportAppService : CrudAppService<
           Report, //The Book entity
           ReportDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateReportDto>, //Used to create/update a book
       IReportAppService //implement the IBookAppService
    {
        public ReportAppService(IRepository<Report, Guid> repository, ICurrentUser currentUser)
            : base(repository)
        {

            this._repository = repository;
            this._currentUser = currentUser;
        }
        private readonly IRepository<Report, Guid> _repository;
        private readonly ICurrentUser _currentUser;
        public override Task<ReportDto> CreateAsync(CreateUpdateReportDto input)
        {
            input.user_id =(Guid) _currentUser.Id;
            input.date = DateTime.Now;
            return base.CreateAsync(input);

        }

    }
}
