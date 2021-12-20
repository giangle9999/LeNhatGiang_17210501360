namespace LeNhatGiang_1721050136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Một : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        MaNhaCungCap = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        NhaCungCap_MaNhaCungCap = c.Int(),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap", t => t.NhaCungCap_MaNhaCungCap)
                .Index(t => t.NhaCungCap_MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPham", "NhaCungCap_MaNhaCungCap", "dbo.NhaCungCap");
            DropIndex("dbo.SanPham", new[] { "NhaCungCap_MaNhaCungCap" });
            DropTable("dbo.SanPham");
            DropTable("dbo.NhaCungCap");
        }
    }
}
