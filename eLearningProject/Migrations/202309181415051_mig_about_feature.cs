namespace eLearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_about_feature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Skill1 = c.String(),
                        Skill2 = c.String(),
                        Skill3 = c.String(),
                        Skill4 = c.String(),
                        Skill5 = c.String(),
                        Skill6 = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        FeatureTitle = c.String(),
                        FeatureIcon = c.String(),
                        FeatureDescription = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Features");
            DropTable("dbo.Abouts");
        }
    }
}
