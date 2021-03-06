﻿
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;


namespace Quizlet_Fake.AuthorSingers
{
    public class Singer : AuditedAggregateRoot<Guid>
    {
        public string name { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string bio { get; set; }
        public string imagepath { get; set; }

    }
}
