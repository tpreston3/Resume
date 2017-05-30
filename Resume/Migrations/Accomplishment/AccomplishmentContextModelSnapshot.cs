using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Resume.Models;

namespace Resume.Migrations.Accomplishment
{
    [DbContext(typeof(AccomplishmentContext))]
    partial class AccomplishmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Resume.Models.Accomplishment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccomplishmentID");

                    b.Property<int?>("JobID");

                    b.Property<string>("accomplishment")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("AccomplishmentID");

                    b.ToTable("Accomplishment");
                });

            modelBuilder.Entity("Resume.Models.Accomplishment", b =>
                {
                    b.HasOne("Resume.Models.Accomplishment")
                        .WithMany("Accomplishments")
                        .HasForeignKey("AccomplishmentID");
                });
        }
    }
}
