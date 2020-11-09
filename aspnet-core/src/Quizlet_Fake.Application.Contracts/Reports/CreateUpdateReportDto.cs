using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Fake.Reports
{
    public class CreateUpdateReportDto
    {
        public DateTime date { get; set; }
        public Guid song_id { get; set; }
        public Guid user_id { get; set; }

        public string content { get; set; }
        public int score { get; set; }
    }
}
