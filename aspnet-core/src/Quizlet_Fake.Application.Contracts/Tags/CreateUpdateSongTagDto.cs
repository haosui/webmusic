using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Fake.Tags
{
    public class CreateUpdateSongTagDto
    {
        public Guid song_id { get; set; }
        public Guid tag_id { get; set; }
    }
}
