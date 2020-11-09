using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Fake.Playlists
{
    public class CreateUpdateIncludeDto
    {
        public Guid song_id { get; set; }
        public Guid playlist_id { get; set; }
    }
}
