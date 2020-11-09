using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.AuthorSingers
{
    public class SongbySingerDto : AuditedEntityDto<Guid>
    {
        public Guid song_id { get; set; }
        public Guid singer_id { get; set; }
        public string songpath { get; set; }
        public string imgpaht { get; set; }
    }
}
