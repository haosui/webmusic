using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.Songs
{
   public class SongDto : AuditedEntityDto<Guid>
    {
        public string name { get; set; }

        public Guid author_id { get; set; }
        public Guid album_id { get; set; }
    }
}
