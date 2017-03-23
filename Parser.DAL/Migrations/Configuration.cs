using System.Data.Entity.Migrations;

namespace Parser.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ParserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Parser.DAL.ParserContext context)
        {
            
        }
    }
}
