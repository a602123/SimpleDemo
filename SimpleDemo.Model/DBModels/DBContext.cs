using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SimpleDemo.Model.DBModels
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAlarm> TbAlarm { get; set; }
        public virtual DbSet<TbAlarmLog> TbAlarmLog { get; set; }
        public virtual DbSet<TbConfig> TbConfig { get; set; }
        public virtual DbSet<TbLine> TbLine { get; set; }
        public virtual DbSet<TbLog> TbLog { get; set; }
        public virtual DbSet<TbOrganization> TbOrganization { get; set; }
        public virtual DbSet<TbRole> TbRole { get; set; }
        public virtual DbSet<TbTelbook> TbTelbook { get; set; }
        public virtual DbSet<TbUser> TbUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;Database=db_clms;User=sa;Password=a602123.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAlarm>(entity =>
            {
                entity.ToTable("tb_alarm");

                entity.Property(e => e.AlarmCount)
                    .HasColumnType("int(30)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Confirm).HasColumnType("bit(1)");

                entity.Property(e => e.FirstTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.LastTime).HasColumnType("datetime");

                entity.Property(e => e.LineId).HasColumnType("int(11)");

                entity.Property(e => e.LineName).HasColumnType("varchar(50)");

                entity.Property(e => e.Note).HasColumnType("varchar(100)");

                entity.Property(e => e.OrganId).HasColumnType("int(30)");

                entity.Property(e => e.OrganName).HasColumnType("varchar(50)");

                entity.Property(e => e.RecoverDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TbAlarmLog>(entity =>
            {
                entity.ToTable("tb_alarm_log");

                entity.Property(e => e.AlarmId).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("varchar(500)");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbConfig>(entity =>
            {
                entity.HasKey(e => e.ConfigName);

                entity.ToTable("tb_config");

                entity.Property(e => e.ConfigName).HasColumnType("varchar(30)");

                entity.Property(e => e.ConfigValue)
                    .IsRequired()
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Note).HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<TbLine>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OrganizationId });

                entity.ToTable("tb_line");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrganizationId).HasColumnType("int(10)");

                entity.Property(e => e.AlarmMax)
                    .HasColumnType("int(30)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.ConnectState)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.Description).HasColumnType("varchar(50)");

                entity.Property(e => e.LineIp)
                    .IsRequired()
                    .HasColumnName("LineIP")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.LineType).HasColumnType("int(10)");

                entity.Property(e => e.Log).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("varchar(20)");

                entity.Property(e => e.PingInterval)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'30'");

                entity.Property(e => e.Pingsize)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'32'");

                entity.Property(e => e.Pingtimes)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'4'");

                entity.Property(e => e.ServiceProvider).HasColumnType("int(10)");

                entity.Property(e => e.Timeout)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'2'");
            });

            modelBuilder.Entity<TbLog>(entity =>
            {
                entity.ToTable("tb_log");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Type).HasColumnType("int(10)");

                entity.Property(e => e.Username).HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<TbOrganization>(entity =>
            {
                entity.ToTable("tb_organization");

                entity.Property(e => e.Description).HasColumnType("varchar(100)");

                entity.Property(e => e.Name).HasColumnType("varchar(20)");

                entity.Property(e => e.ParentId).HasColumnType("int(10)");

                entity.Property(e => e.Smstelephone)
                    .HasColumnName("SMSTelephone")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.State).HasDefaultValueSql("'1'");

                entity.Property(e => e.X).HasColumnType("varchar(10)");

                entity.Property(e => e.Y).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<TbRole>(entity =>
            {
                entity.ToTable("tb_role");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Note).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TbTelbook>(entity =>
            {
                entity.ToTable("tb_telbook");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.ToTable("tb_user");

                entity.Property(e => e.Email).HasColumnType("varchar(30)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RealName).HasColumnType("varchar(20)");

                entity.Property(e => e.RoleId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.State)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Telphone).HasColumnType("varchar(20)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });
        }
    }
}
