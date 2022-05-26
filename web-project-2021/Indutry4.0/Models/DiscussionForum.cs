using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Indutry4._0.Models
{
    public class DiscussionForum
    {
        public int Id { get; set; }

        //[Display(Name = "Post Date")]
        //public DateTime PostDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //[Display(Name = "User Name")]
        public string UserName { get; set; }

        //[Required]
        //[Display(Name = "Topic Title")]
        //public string TopicTitle { get; set; }

        [Required]
        public string Heading { get; set; }

        //[Required]
        //[Display(Name = "Message Content")]
        //public string MessageContent { get; set; }

        public int StarRating { get; set; }

        [Required]
        public string Feedback { get; set; }

        //public int Like { get; set; }

        public int Agree { get; set; }

        public int Disagree { get; set; }

        [Required]
        public string CompanyOrganizationName { get; set; }

        public bool canIncreaseAgree { get; set; }

        public bool canIncreaseDisagree { get; set; }

    }
}
