using Microsoft.EntityFrameworkCore;
namespace EduPulse_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// User -> Student (One-to-One)
			modelBuilder.Entity<Student>()
				.HasOne(s => s.User)
				.WithOne()
				.HasForeignKey<Student>(s => s.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			// User -> Teacher (One-to-One)
			modelBuilder.Entity<Teacher>()
				.HasOne(t => t.User)
				.WithOne()
				.HasForeignKey<Teacher>(t => t.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			// Course -> Subject (One-to-Many)
			modelBuilder.Entity<Subject>()
				.HasOne(s => s.Course)
				.WithMany()
				.HasForeignKey(s => s.CourseId)
				.OnDelete(DeleteBehavior.Restrict);

			// Teacher -> TeacherSubject
			modelBuilder.Entity<TeacherSubject>()
				.HasOne(ts => ts.Teacher)
				.WithMany()
				.HasForeignKey(ts => ts.TeacherId)
				.OnDelete(DeleteBehavior.Restrict);

			// Subject -> TeacherSubject
			modelBuilder.Entity<TeacherSubject>()
				.HasOne(ts => ts.Subject)
				.WithMany()
				.HasForeignKey(ts => ts.SubjectId)
				.OnDelete(DeleteBehavior.Restrict);

			// Student -> Enrollment
			modelBuilder.Entity<Enrollment>()
				.HasOne(e => e.Student)
				.WithMany()
				.HasForeignKey(e => e.StudentId)
				.OnDelete(DeleteBehavior.Restrict);

			// Course -> Enrollment
			modelBuilder.Entity<Enrollment>()
				.HasOne(e => e.Course)
				.WithMany()
				.HasForeignKey(e => e.CourseId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
