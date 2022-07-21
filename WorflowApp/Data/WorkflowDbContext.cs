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
            modelBuilder.Entity<UserRequest>(entity =>
            {

                entity.HasKey(e => new { e.UserId, e.RequestId });

                entity.ToTable("User_Request");

                entity.HasOne(r => r.Request)
                      .WithMany(u => u.UserRequests)
                      .HasForeignKey(r => r.RequestId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_Request_User");

                entity.HasOne(r => r.User)
                      .WithMany(u => u.UserRequests)
                      .HasForeignKey(r => r.UserId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_UserRequest");

            });

        }
    }
}
