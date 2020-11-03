using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Quizlet_Fake.Tags
{
    public class SongTag : AuditedAggregateRoot<Guid>
    {
        public Guid song_id { get; set; }
        public Guid tag_id { get; set; }

    }
    
}
