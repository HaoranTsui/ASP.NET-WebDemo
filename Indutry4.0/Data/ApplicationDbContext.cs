using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Indutry4._0.Models;

namespace Indutry4._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Indutry4._0.Models.DiscussionForum> DiscussionForum { get; set; }
        public DbSet<Indutry4._0.Models.FeedbackPost> FeedbackPost { get; set; }
    }
}
