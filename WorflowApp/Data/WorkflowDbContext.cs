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
                // one to many relation : Request/TypeRequest
                modelBuilder.Entity<Request>()
                            .HasOne(r => r.TypeRequest)
                            .WithMany(t=> t.Requests);
                // one to many relation : User/Position
                modelBuilder.Entity<User>()
                            .HasOne(u => u.Position)
                            .WithMany(p=> p.Users);
                // one to many relation : 
                // many to many : Request/User --> UserRequest
                modelBuilder.Entity<UserRequest>(entity =>
                {

                    entity.HasKey(e => new { e.UserId, e.RequestId });

                    entity.ToTable("UserRequest");

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
