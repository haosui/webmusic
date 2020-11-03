using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Quizlet_Fake.Playlists
{
    public class Playlist : AuditedAggregateRoot<Guid>
    {
        public Guid user_id { get; set; }
        public string name { get; set; }

    }
    
}
