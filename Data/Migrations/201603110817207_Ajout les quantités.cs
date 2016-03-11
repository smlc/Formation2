namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajoutlesquantités : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RecipeDBs", "Servings", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RecipeDBs", "Servings");
        }
    }
}
