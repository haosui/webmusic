using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Quizlet_Fake.Playlists
{
    public class Include : AuditedAggregateRoot<Guid>
    {
        public Guid song_id { get; set; }
        public Guid playlist_id { get; set; }

    }
   
}
