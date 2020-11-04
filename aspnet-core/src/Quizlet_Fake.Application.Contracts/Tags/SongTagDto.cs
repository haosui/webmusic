using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.Tags
{
    public class SongTagDto : AuditedEntityDto<Guid>
    {
        public Guid song_id { get; set; }
        public Guid tag_id { get; set; }
    }
    
}
