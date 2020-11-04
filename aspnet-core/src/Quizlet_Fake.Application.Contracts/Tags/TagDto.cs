using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.Tags
{
    public class TagDto: AuditedEntityDto<Guid>
    {
        public string name { get; set; }
        public string description { get; set; }
    }
    
}
