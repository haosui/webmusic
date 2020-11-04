using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Quizlet_Fake.Reports
{
    public interface IReportAppService :
        ICrudAppService< //Defines CRUD methods
            ReportDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateReportDto> //Used to create/update a book
    {

    }
    
}
