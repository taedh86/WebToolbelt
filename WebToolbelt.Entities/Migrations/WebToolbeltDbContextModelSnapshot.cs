using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebToolbelt.Entities.DbContext;

namespace WebToolbelt.Entities.Migrations
{
    [DbContext(typeof(WebToolbeltDbContext))]
    partial class WebToolbeltDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebToolbelt.Entities.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("EnglishName");

                    b.Property<string>("NativeName");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });
        }
    }
}
