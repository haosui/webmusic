using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

namespace Quizlet_Fake.Songs
{
    public class LyricDto : AuditedEntityDto<Guid>
    {
        public string lyric { get; set; }

        public Guid song_id { get; set; }
    }
   
}
