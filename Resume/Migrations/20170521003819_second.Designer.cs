using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Resume.Models;

namespace Resume.Migrations
{
    [DbContext(typeof(ResumeContext))]
    [Migration("20170521003819_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Resume.Controllers.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<int>("StreetNumber");

                    b.Property<int>("ZipCode");

                    b.HasKey("ID");

                    b.ToTable("Contact");
                });
        }
    }
}
