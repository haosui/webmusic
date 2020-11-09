using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Quizlet_Fake.Reports
{
    public class ReportDto: AuditedEntityDto<Guid>
    {
        public DateTime date { get; set; }
        public Guid song_id { get; set; }
        public Guid user_id { get; set; }
        public string username { get; set; }
        public string content { get; set; }
        public int score { get; set; }
    }
}
