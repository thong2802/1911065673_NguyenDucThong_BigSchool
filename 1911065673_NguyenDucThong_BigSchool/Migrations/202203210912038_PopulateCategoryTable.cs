namespace _1911065673_NguyenDucThong_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(1, 'Delopment')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(2, ' Bessiness')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(3, 'Markting')");
        }
        
        public override void Down()
        {
        }
    }
}
