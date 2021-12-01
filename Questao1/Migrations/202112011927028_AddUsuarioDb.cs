namespace Questao1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsuarioDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Atividades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Sexo = c.String(),
                        Idade = c.Int(nullable: false),
                        Peso = c.Int(nullable: false),
                        Altura = c.Int(nullable: false),
                        IMC = c.Int(nullable: false),
                        FichaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Fichas", t => t.FichaId, cascadeDelete: true)
                .Index(t => t.FichaId);
            
            CreateTable(
                "dbo.Fichas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataCriacao = c.DateTime(),
                        NomeInstrutor = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Serie = c.String(),
                        Descricao = c.String(),
                        Repeticao = c.String(),
                        Peso = c.Int(nullable: false),
                        FichaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Fichas", t => t.FichaId, cascadeDelete: true)
                .Index(t => t.FichaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "FichaId", "dbo.Fichas");
            DropForeignKey("dbo.Atividades", "FichaId", "dbo.Fichas");
            DropIndex("dbo.Usuarios", new[] { "FichaId" });
            DropIndex("dbo.Atividades", new[] { "FichaId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Fichas");
            DropTable("dbo.Atividades");
        }
    }
}
