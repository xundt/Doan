using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ForKids.Models;

public partial class BabyCareContext : DbContext
{
    public BabyCareContext()
    {
    }

    public BabyCareContext(DbContextOptions<BabyCareContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbBooking> TbBookings { get; set; }

    public virtual DbSet<TbContact> TbContacts { get; set; }

    public virtual DbSet<TbEvent> TbEvents { get; set; }

    public virtual DbSet<TbFAQ> TbFaqs { get; set; }

    public virtual DbSet<TbGallery> TbGalleries { get; set; }

    public virtual DbSet<TbMenu> TbMenus { get; set; }

    public virtual DbSet<TbProgram> TbPrograms { get; set; }

    public virtual DbSet<TbService> TbServices { get; set; }

    public virtual DbSet<TbTestimonial> TbTestimonials { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source= LAPTOP-AIDO\\SQLEXPRESS; initial catalog=Baby_Care; integrated security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbBooking>(entity =>
        {
            entity.HasKey(e => e.BookingId);

            entity.ToTable("tb_Bookings");

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.Descriptions).HasMaxLength(2500);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TbContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_Contacts");

            entity.Property(e => e.ContactDate).HasColumnType("datetime");
            entity.Property(e => e.ContactId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ContactID");
            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.Message).HasMaxLength(300);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TbEvent>(entity =>
        {
            entity.HasKey(e => e.EventsId);

            entity.ToTable("tb_Events");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.Eventsname).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(150);
        });

        modelBuilder.Entity<TbFAQ>(entity =>
        {
            entity.HasKey(e => e.Faqid);

            entity.ToTable("tb_FAQ");

            entity.Property(e => e.Faqid).HasColumnName("FAQId");
            entity.Property(e => e.Answer).HasMaxLength(300);
            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.Question).HasMaxLength(200);
        });

        modelBuilder.Entity<TbGallery>(entity =>
        {
            entity.HasKey(e => e.GalleryId);

            entity.ToTable("tb_Gallery");

            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.Type).HasMaxLength(300);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_Menu");

            entity.Property(e => e.Alias).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.MenuId).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<TbProgram>(entity =>
        {
            entity.HasKey(e => e.ProgramsId);

            entity.ToTable("tb_Programs");

            entity.Property(e => e.AgeGroup).HasMaxLength(100);
            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.Duration).HasMaxLength(100);
            entity.Property(e => e.Prince).HasMaxLength(1);
            entity.Property(e => e.Programsname).HasMaxLength(50);
        });

        modelBuilder.Entity<TbService>(entity =>
        {
            entity.HasKey(e => e.ServicesId);

            entity.ToTable("tb_Services");

            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.Prince).HasMaxLength(50);
            entity.Property(e => e.Servicesname).HasMaxLength(50);
        });

        modelBuilder.Entity<TbTestimonial>(entity =>
        {
            entity.HasKey(e => e.TestimonialId);

            entity.ToTable("tb_Testimonials");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.Message).HasMaxLength(300);
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tb_Users");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Descriptions).HasMaxLength(2000);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
