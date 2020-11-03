using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Quizlet_Fake.Tags
{
    public class Tag : AuditedAggregateRoot<Guid>
    {
        public string name { get; set; }
        public string description { get; set; }

    }
    
}
