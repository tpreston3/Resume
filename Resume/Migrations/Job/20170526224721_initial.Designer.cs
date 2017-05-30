using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Resume.Models;

namespace Resume.Migrations.Job
{
    [DbContext(typeof(JobContext))]
    [Migration("20170526224721_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Resume.Models.Job", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Accomplishments");

                    b.Property<string>("EmployerName")
                        .IsRequired();

                    b.Property<string>("JobDescription");

                    b.Property<string>("JobTitle")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("StopDate");

                    b.HasKey("ID");

                    b.ToTable("Job");
                });
        }
    }
}
