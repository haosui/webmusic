using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.Playlists
{
   public class PlaylistDto :AuditedEntityDto<Guid>
    {
        public Guid user_id { get; set; }
        public string name { get; set; }
    }
}
