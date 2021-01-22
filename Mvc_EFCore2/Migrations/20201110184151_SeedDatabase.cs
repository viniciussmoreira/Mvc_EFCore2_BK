using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_EFCore2.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Alunos (Nome,Sexo,Email,Nascimento) VALUES ('Macoratti','Masculino','macoratti@yahoo.com','04/08/1975')");
            migrationBuilder.Sql("INSERT INTO Alunos (Nome,Sexo,Email,Nascimento) VALUES ('Macoratti2','Masculino','macoratti@yahoo.com','04/08/1975')");
            migrationBuilder.Sql("INSERT INTO Alunos (Nome,Sexo,Email,Nascimento) VALUES ('Macoratti3','Masculino','macoratti@yahoo.com','04/08/1975')");
            migrationBuilder.Sql("INSERT INTO Alunos (Nome,Sexo,Email,Nascimento) VALUES ('Macoratti4','Masculino','macoratti@yahoo.com','04/08/1975')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Alunos");
        }
    }
}
