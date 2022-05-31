using System;
using System.Collections.Generic;

#nullable disable

namespace Indutry4._0.Models
{
    public partial class DiscussionForum
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public int Agree { get; set; }
        public int Disagree { get; set; }
    }
}
