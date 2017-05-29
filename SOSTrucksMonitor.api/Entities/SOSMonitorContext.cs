using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SOSTrucksMonitor.api.Entities
{
    public partial class SOSMonitorContext : DbContext
    {
        public virtual DbSet<Broker> Broker { get; set; }
        public virtual DbSet<DeliveryAttributeStatus> DeliveryAttributeStatus { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Load> Load { get; set; }
        public virtual DbSet<PickUpAttributeStatus> PickUpAttributeStatus { get; set; }
        public virtual DbSet<TruckMonitor> TruckMonitor { get; set; }

        public SOSMonitorContext(DbContextOptions<SOSMonitorContext> dbContextOptions)
            :base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broker>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(50)");

                entity.HasOne(d => d.TruckMonitor)
                    .WithMany(p => p.Broker)
                    .HasForeignKey(d => d.TrucksMonitorId)
                    .HasConstraintName("FK_Broker_TrucksMonitor");
            });

            modelBuilder.Entity<DeliveryAttributeStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type).HasColumnType("varchar(50)");

                entity.Property(e => e.Value).HasColumnType("varchar(50)");

                entity.HasOne(d => d.TruckMonitor)
                    .WithMany(p => p.DeliveryAttributeStatus)
                    .HasForeignKey(d => d.TrucksMonitorId)
                    .HasConstraintName("FK_DeliveryAttributeStatus_TrucksMonitor");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(50)");

                entity.HasOne(d => d.TruckMonitor)
                    .WithMany(p => p.Driver)
                    .HasForeignKey(d => d.TrucksMonitorId)
                    .HasConstraintName("FK_Driver_TrucksMonitor");
            });

            modelBuilder.Entity<Load>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type).HasColumnType("varchar(50)");

                entity.Property(e => e.Value).HasColumnType("varchar(50)");

                entity.HasOne(d => d.TruckMonitor)
                    .WithMany(p => p.Load)
                    .HasForeignKey(d => d.TrucksMonitorId)
                    .HasConstraintName("FK_Load_TrucksMonitor");
            });

            modelBuilder.Entity<PickUpAttributeStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type).HasColumnType("varchar(50)");

                entity.Property(e => e.Value).HasColumnType("varchar(50)");

                entity.HasOne(d => d.TruckMonitor)
                    .WithMany(p => p.PickUpAttributeStatus)
                    .HasForeignKey(d => d.TrucksMonitorId)
                    .HasConstraintName("FK_PickUpAttributeStatus_TrucksMonitor");
            });

            modelBuilder.Entity<TruckMonitor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaseCity).HasColumnType("varchar(50)");

                entity.Property(e => e.Customer).HasColumnType("varchar(80)");

                entity.Property(e => e.CustomerReference).HasColumnType("varchar(50)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Dispatcher).HasColumnType("varchar(50)");

                entity.Property(e => e.FileNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.From).HasColumnType("varchar(50)");

                entity.Property(e => e.Invoice).HasColumnType("varchar(50)");

                entity.Property(e => e.To).HasColumnType("varchar(50)");

                entity.Property(e => e.TrailerNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.TruckNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.TruckOwner).HasColumnType("varchar(50)");
            });
        }
    }
}