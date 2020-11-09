using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Quizlet_Fake.Songs
{
    public class Song : AuditedAggregateRoot<Guid>
    {
        public string name { get; set; }

        public Guid author_id { get; set; }
        public Guid album_id { get; set; }

        public Guid singer_id { get; set; }



        public DateTime publishdate { get; set; }
        public string songpath { get; set; }
        public string imagepath { get; set; }

        public string rating { get; set; }

        public int views { get; set; }
        public int reviewamount { get; set; }
    }
}
