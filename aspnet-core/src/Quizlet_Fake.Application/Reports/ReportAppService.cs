using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
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
        public ReportAppService(IRepository<Report, Guid> repository)
            : base(repository)
        {

            this._repository = repository;
        }
        private readonly IRepository<Report, Guid> _repository;



    }
}
