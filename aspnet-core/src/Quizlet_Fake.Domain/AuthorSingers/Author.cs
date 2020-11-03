using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;


namespace Quizlet_Fake.AuthorSingers
{
    public class Author : AuditedAggregateRoot<Guid>
    {
        public  string name { get;  set; }
        public  string description { get;  set; }
        public string imagepath { get; set; }

    }
}
