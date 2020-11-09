using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.Playlists
{
    public class IncludeDto : AuditedEntityDto<Guid>
    {
        public Guid song_id { get; set; }
        public Guid playlist_id { get; set; }
    }
}
