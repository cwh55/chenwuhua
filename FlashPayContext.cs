using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using Test.Model;

namespace Test
{
    public class FlashPayContext : DbContext
    {
        private string _month = DateTime.Now.ToString("MM");
        //private string _mydb = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build()["ConnectionStrings:FlashPay"];

        public FlashPayContext()
        {
        }

        public FlashPayContext(DbContextOptions<FlashPayContext> options)
            : base(options)
        {

        }

        public virtual DbSet<PaymentInterface> PaymentInterface { get; set; }
        public virtual DbSet<PaymentRecord> PaymentRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PaymentInterface>().ToTable("PaymentInterface");

            //modelBuilder.Entity<PaymentInterface>(entity =>
            //{
            //    entity.HasKey(e => new { e.CompanyId, e.PaymentType });

            //    entity.HasKey(e => e.CompanyId);

            //    entity.Property(e => e.CompanyId)
            //        .HasColumnName("CompanyID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.PaymentType).HasColumnType("tinyint(4)");

            //    entity.Property(e => e.CompanyName).HasColumnType("varchar(50)");

            //    entity.Property(e => e.DepositType)
            //        .IsRequired()
            //        .HasDefaultValueSql("''");

            //    entity.Property(e => e.LimitCloseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LimitOpenDate).HasColumnType("datetime");

            //    entity.Property(e => e.LimitRepeat)
            //        .HasColumnType("tinyint(4)")
            //        .HasDefaultValueSql("'2'");

            //    entity.Property(e => e.LimitStatus)
            //        .HasColumnType("tinyint(4)")
            //        .HasDefaultValueSql("'2'");

            //    entity.Property(e => e.PaymentEnd)
            //        .HasColumnType("decimal(16,4)")
            //        .HasDefaultValueSql("'0.0000'");

            //    entity.Property(e => e.PaymentMax)
            //        .HasColumnType("int(11)")
            //        .HasDefaultValueSql("'0'");

            //    entity.Property(e => e.PaymentStart)
            //        .HasColumnType("decimal(16,4)")
            //        .HasDefaultValueSql("'0.0000'");

            //    entity.Property(e => e.SecretKey).HasColumnType("text");

            //    entity.Property(e => e.WithdrawalBank).HasColumnType("varchar(500)");
            //});
            //modelBuilder.Entity<PaymentRecord>(entity =>
            //{
            //    entity.HasKey(e => e.OrderNo);

            //    entity.ToTable("PaymentRecord_" + _month);

            //    entity.HasIndex(e => e.CreateDate)
            //        .HasName("ix_CreateDate");

            //    entity.HasIndex(e => e.PaymentCardId)
            //        .HasName("ix_PaymentCardID");

            //    entity.HasIndex(e => e.PaymentDate)
            //        .HasName("ix_PaymentDate");

            //    entity.HasIndex(e => new { e.CompanyId, e.WithdrawalOrderNo })
            //        .HasName("ix_CompanyID_WithdrawalOrderNo")
            //        .IsUnique();

            //    entity.Property(e => e.OrderNo).HasColumnType("bigint(20)");

            //    entity.Property(e => e.AfterBalance).HasColumnType("decimal(16,4)");

            //    entity.Property(e => e.BankSerialNo).HasColumnType("varchar(50)");

            //    entity.Property(e => e.BeforeBalance).HasColumnType("decimal(16,4)");

            //    entity.Property(e => e.CardNumber).HasColumnType("varchar(30)");

            //    entity.Property(e => e.CompanyId)
            //        .HasColumnName("CompanyID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

            //    entity.Property(e => e.ConfirmName).HasColumnType("varchar(128)");

            //    entity.Property(e => e.ConfirmStatus)
            //        .HasColumnType("tinyint(4)")
            //        .HasDefaultValueSql("'0'");

            //    entity.Property(e => e.ConfirmUid)
            //        .HasColumnName("ConfirmUID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.CreateDbdate)
            //        .HasColumnName("CreateDBDate")
            //        .HasDefaultValueSql("'current_timestamp(6)'");

            //    entity.Property(e => e.DepositType).HasColumnType("char(1)");

            //    entity.Property(e => e.FeeRatio).HasColumnType("decimal(12,8)");

            //    entity.Property(e => e.FeeTotal).HasColumnType("decimal(16,4)");

            //    entity.Property(e => e.NoticeLastDate).HasColumnType("datetime");

            //    entity.Property(e => e.NoticeStatus)
            //        .HasColumnType("tinyint(4)")
            //        .HasDefaultValueSql("'1'");

            //    entity.Property(e => e.NoticeTimes)
            //        .HasColumnType("int(11)")
            //        .HasDefaultValueSql("'0'");

            //    entity.Property(e => e.PaymentCardId)
            //        .HasColumnName("PaymentCardID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.PaymentDate).HasColumnType("datetime");

            //    entity.Property(e => e.PaymentFailInfo).HasColumnType("text");

            //    entity.Property(e => e.PaymentRemark).HasColumnType("text");

            //    entity.Property(e => e.PaymentStatus)
            //        .HasColumnType("tinyint(4)")
            //        .HasDefaultValueSql("'1'");

            //    entity.Property(e => e.PaymentType)
            //        .HasColumnType("tinyint(4)")
            //        .HasDefaultValueSql("'0'");

            //    entity.Property(e => e.ReadDate).HasColumnType("datetime");

            //    entity.Property(e => e.RecordRealOrderNo).HasColumnType("bigint(20)");

            //    entity.Property(e => e.WithdrawalAccountName)
            //        .IsRequired()
            //        .HasColumnType("varchar(50)");

            //    entity.Property(e => e.WithdrawalAmount).HasColumnType("decimal(16,4) unsigned");

            //    entity.Property(e => e.WithdrawalBankAddress).HasColumnType("varchar(1024)");

            //    entity.Property(e => e.WithdrawalBankName)
            //        .IsRequired()
            //        .HasColumnType("varchar(150)");

            //    entity.Property(e => e.WithdrawalCardBankFlag)
            //        .IsRequired()
            //        .HasColumnType("varchar(50)");

            //    entity.Property(e => e.WithdrawalCardNumber)
            //        .IsRequired()
            //        .HasColumnType("varchar(64)");

            //    entity.Property(e => e.WithdrawalOrderNo)
            //        .IsRequired()
            //        .HasColumnType("varchar(128)");
            //});
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(_mydb);

            try
            {
                IConfigurationRoot configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                string _mydb = configBuilder["ConnectionStrings:FlashPay"];
                if (string.IsNullOrEmpty(_mydb))
                {
                    UPAYAPI.Common.StringHelper.WriteLog("数据库连接字符串为空");
                }
                else
                {
                    optionsBuilder.UseMySql(_mydb);
                }
            }
            catch (Exception)
            {
                UPAYAPI.Common.StringHelper.WriteLog("数据库配置文件AppSetting.json不存在");
            }
        }
    }
}



 //根据商户号获取SecretKey
        public static string GetSecretKey(string custid,int type=2)
        {
            using (var db = new Test.FlashPayContext())
            {
                var q = db.PaymentInterface.Where(e => e.CompanyName == custid && e.PaymentType == type).FirstOrDefault();
                if (q == null) return "";
                return q.SecretKey;
            }
        }
