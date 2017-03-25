using System.Data.Entity;
using Parser.DAL.Entities;

namespace Parser.DAL
{
    internal class ParserContext : DbContext
    {
        public ParserContext() : base("ParserContextConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ParserContext>());
        }
        public DbSet<LiquidEntity> Liquids { get; set; }
    }

}
