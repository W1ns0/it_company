using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace it_company.Models;

public partial class ItCompanyContext : DbContext
{
    public ItCompanyContext()
    {
    }

    public ItCompanyContext(DbContextOptions<ItCompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleInProject> RoleInProjects { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserInProject> UserInProjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=it_company;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Priority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("priorities_pkey");

            entity.ToTable("priorities");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PriorityName).HasColumnName("priority_name");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("projects_pkey");

            entity.ToTable("projects");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfStart).HasColumnName("date_of_start");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.NameProject).HasColumnName("name_project");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.User).WithMany(p => p.Projects)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_projects_to_users");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<RoleInProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("role_in_projects_pkey");

            entity.ToTable("role_in_projects");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tasks_pkey");

            entity.ToTable("tasks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfCreate).HasColumnName("date_of_create");
            entity.Property(e => e.DateOfEnd).HasColumnName("date_of_end");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdPriority).HasColumnName("id_priority");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUserInProject).HasColumnName("id_user_in_project");
            entity.Property(e => e.NameTask).HasColumnName("name_task");

            entity.HasOne(d => d.Priority).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdPriority)
                .HasConstraintName("fk_tasks_to_priorities");

            entity.HasOne(d => d.Status).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("fk_tasks_to_statuses");

            entity.HasOne(d => d.UserInProject).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdUserInProject)
                .HasConstraintName("fk_tasks_to_user_in_projects");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Pass).HasColumnName("pass");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("fk_users_to_roles");
        });

        modelBuilder.Entity<UserInProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_in_projects_pkey");

            entity.ToTable("user_in_projects");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdRoleInProject).HasColumnName("id_role_in_project");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.Project).WithMany(p => p.UserInProjects)
                .HasForeignKey(d => d.IdProject)
                .HasConstraintName("fk_user_in_projects_to_projects");

            entity.HasOne(d => d.RoleInProject).WithMany(p => p.UserInProjects)
                .HasForeignKey(d => d.IdRoleInProject)
                .HasConstraintName("fk_user_in_projects_to_role_in_projects");

            entity.HasOne(d => d.User).WithMany(p => p.UserInProjects)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_user_in_projects_to_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
