using System;
using System.Collections.Generic;

#nullable disable

namespace Indutry4._0.Models
{
    public partial class FeedbackPost
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Heading { get; set; }
        public int StarRating { get; set; }
        public string Feedback { get; set; }
        public int Agree { get; set; }
        public int Disagree { get; set; }
        public string CompanyOrganizationName { get; set; }
        public bool CanIncreaseAgree { get; set; }
        public bool CanIncreaseDisagree { get; set; }
    }
}
