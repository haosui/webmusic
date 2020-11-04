using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Fake.Songs
{
    public class CreateUpdateLyricDto
    
    {
        public string lyric { get; set; }

        public Guid song_id { get; set; }
    }
}

