namespace курсач
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Professional_unit> Professional_units { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Student_profile> Student_profile { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Test_correct_answer> Test_correct_answers { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professional_unit>()
                .Property(e => e.Name_of_PU)
                .IsUnicode(false);

            modelBuilder.Entity<Professional_unit>()
                .HasMany(e => e.Results)
                .WithOptional(e => e.Professional_units)
                .HasForeignKey(e => e.PU_name);

            modelBuilder.Entity<Professional_unit>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.Professional_units)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.PU_name)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.Answers)
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .HasMany(e => e.Student_profile)
                .WithOptional(e => e.Result)
                .HasForeignKey(e => e.Result_ID);

            modelBuilder.Entity<Student_profile>()
                .Property(e => e.Student_login)
                .IsUnicode(false);

            modelBuilder.Entity<Student_profile>()
                .Property(e => e.PU_learned)
                .IsUnicode(false);

            modelBuilder.Entity<Student_profile>()
                .Property(e => e.Correct_tests)
                .IsUnicode(false);

            modelBuilder.Entity<Test_correct_answer>()
                .Property(e => e.Name_of_PU)
                .IsUnicode(false);

            modelBuilder.Entity<Test_correct_answer>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Test_correct_answer>()
                .Property(e => e.Correct_answers)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.Test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.Name_of_PU)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.Answers)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.Student_login)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Test_correct_answers)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Student_profile)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Student_login)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tests)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Student_login);
        }
    }
}
