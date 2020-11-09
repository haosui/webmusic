using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Fake.Songs
{
    public class CreateUpdateSongDto
    {
        public string name { get; set; }

        public Guid author_id { get; set; }
        public Guid album_id { get; set; }
        public Guid singer_id { get; set; }
        public string songpath { get; set; }
        public string imagepath { get; set; }
        
    }
}
