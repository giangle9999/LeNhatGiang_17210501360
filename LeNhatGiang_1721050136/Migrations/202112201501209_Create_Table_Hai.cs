namespace LeNhatGiang_1721050136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Hai : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SanPham", "NhaCungCap_MaNhaCungCap", "dbo.NhaCungCap");
            DropIndex("dbo.SanPham", new[] { "NhaCungCap_MaNhaCungCap" });
            RenameColumn(table: "dbo.SanPham", name: "NhaCungCap_MaNhaCungCap", newName: "Manhacungcap");
            AlterColumn("dbo.SanPham", "Manhacungcap", c => c.Int(nullable: false));
            CreateIndex("dbo.SanPham", "Manhacungcap");
            AddForeignKey("dbo.SanPham", "Manhacungcap", "dbo.NhaCungCap", "MaNhaCungCap", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPham", "Manhacungcap", "dbo.NhaCungCap");
            DropIndex("dbo.SanPham", new[] { "Manhacungcap" });
            AlterColumn("dbo.SanPham", "Manhacungcap", c => c.Int());
            RenameColumn(table: "dbo.SanPham", name: "Manhacungcap", newName: "NhaCungCap_MaNhaCungCap");
            CreateIndex("dbo.SanPham", "NhaCungCap_MaNhaCungCap");
            AddForeignKey("dbo.SanPham", "NhaCungCap_MaNhaCungCap", "dbo.NhaCungCap", "MaNhaCungCap");
        }
    }
}
