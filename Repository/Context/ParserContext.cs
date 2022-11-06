using FileContextCore;
using Microsoft.EntityFrameworkCore;
using resume_mixer.Models.Parser;

namespace resume_mixer.Repository.Context
{
    public class ParserContext : DbContext
    {
        public DbSet<ApplicantModel> Applicants { get; set; }

        public DbSet<DescriptionModel> Descriptions { get; set; }

        public DbSet<EmployerModel> Employers { get; set; }

        public DbSet<HeaderModel> Headers { get; set; }

        public DbSet<KeywordModel> Keywords { get; set; }

        public DbSet<PlatformModel> Platforms { get; set; }

        public DbSet<RelationModel> Relations { get; set; }

        public DbSet<StackModel> Stacks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Default: JSON-Serializer
            optionsBuilder.UseFileContextDatabase();

            // optionsBuilder.UseFileContextDatabase<JSONSerializer, DefaultFileManager>();

            // optionsBuilder.UseFileContextDatabase<BSONSerializer, DefaultFileManager>();

            //JSON-Serialize + simple Encryption
            // optionsBuilder.UseFileContextDatabase<JSONSerializer, EncryptedFileManager>();

            //XML
            // optionsBuilder.UseFileContextDatabase<XMLSerializer, DefaultFileManager>();
            // optionsBuilder.UseFileContextDatabase<XMLSerializer, PrivateFileManager>();

            //CSV
            // optionsBuilder.UseFileContextDatabase<CSVSerializer, DefaultFileManager>();

            //Custom location
            // optionsBuilder.UseFileContextDatabase(location: @"D:\t");

            //Excel
            // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // optionsBuilder.UseFileContextDatabase<EXCELStoreManager>(databaseName: "test");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantModel>()
                .ToTable("custom_user_table");
        }
    }
}