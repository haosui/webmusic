using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.AuthorSingers
{
    public class AuthorDto  : AuditedEntityDto<Guid>
    {
        public string name { get; set; }
        public string description { get; set; }
        public string imagepath { get; set; }
    }
}
