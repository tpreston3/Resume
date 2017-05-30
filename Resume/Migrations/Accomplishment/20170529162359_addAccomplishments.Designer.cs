using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Resume.Models;

namespace Resume.Migrations.Accomplishment
{
    [DbContext(typeof(AccomplishmentContext))]
    [Migration("20170529162359_addAccomplishments")]
    partial class addAccomplishments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
