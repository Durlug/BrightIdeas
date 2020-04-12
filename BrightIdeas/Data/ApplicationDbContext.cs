//using System.Data.Entity;
using BrightIdeas.Models;
using Microsoft.EntityFrameworkCore;

namespace BrightIdeas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Crediential> Credientials { get; set; }
        public DbSet<Idea> Idea { get; set; }
        public DbSet<IdeaFollower> IdeaFollowers { get; set; }
        public DbSet<IdeaReport> IdeaReports { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Posting> Postings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ToDo>  ToDos { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<UserReport> UserReports { get; set; }

        public DbSet<BrightIdeas.Models.PasswordNames> PasswordNames { get; set; }


    }
}