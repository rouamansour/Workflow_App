using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class WorkflowDbContext : DbContext
    {
        public WorkflowDbContext(DbContextOptions<WorkflowDbContext> options) : base(options)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<TypeRequest> TypeRequests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Request>()
                            .HasOne(r => r.TypeRequest)
                            .WithMany(t=> t.Requests);

                modelBuilder.Entity<User>()
                            .HasOne(u => u.Position)
                            .WithMany(p=> p.Users);

                //modelBuilder.Entity<UserRequest>()(e => new { e.RequestId, e.UserId });

                //modelBuilder.Entity.ToTable("User");

                //modelBuilder.Entity.HasOne(d => d.Request)
                //            .WithMany(p => p.User)
                //            .HasForeignKey(d => d.RequestId)
                //            .HasConstraintName("FK_Request_User");

                //modelBuilder.Entity.HasOne(d => d.User)
                //            .WithMany(p => p.User)
                //            .HasForeignKey(d => d.UserId)
                //            .HasConstraintName("FK_UserRequest");

        }
    }
}
