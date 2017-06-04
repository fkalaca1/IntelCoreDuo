using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ParKingMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    BrojTelefona = table.Column(type: "TEXT", nullable: true),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Sifra = table.Column(type: "TEXT", nullable: true),
                    UserId = table.Column(type: "INTEGER", nullable: true)
                        //.Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorId);
                });
            migration.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    BrojTelefona = table.Column(type: "TEXT", nullable: true),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Sifra = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
            migration.CreateTable(
                name: "VlasnikParkinga",
                columns: table => new
                {
                    VlasnikParkingaId = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    BrojTelefona = table.Column(type: "TEXT", nullable: true),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Sifra = table.Column(type: "TEXT", nullable: true),
                    UserId = table.Column(type: "INTEGER", nullable: true)
                      //  .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VlasnikParkinga", x => x.VlasnikParkingaId);
                });
            migration.CreateTable(
                name: "Parking",
                columns: table => new
                {
                    ParkingId = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    Cijena = table.Column(type: "REAL", nullable: false),
                    GeoDuzina = table.Column(type: "REAL", nullable: false),
                    GeoSirina = table.Column(type: "REAL", nullable: false),
                    Kapacitet = table.Column(type: "INTEGER", nullable: false),
                    VlasnikParkingaVlasnikParkingaId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.ParkingId);
                    table.ForeignKey(
                        name: "FK_Parking_VlasnikParkinga_VlasnikParkingaVlasnikParkingaId",
                        columns: x => x.VlasnikParkingaVlasnikParkingaId,
                        referencedTable: "VlasnikParkinga",
                        referencedColumn: "VlasnikParkingaId");
                });
            migration.CreateTable(
                name: "ParkingRezervacija",
                columns: table => new
                {
                    ParkingRezervacijaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    BrojMjestaZR = table.Column(type: "INTEGER", nullable: false),
                    BrojTelefona = table.Column(type: "TEXT", nullable: true),
                    BrojZauzetihMjesta = table.Column(type: "INTEGER", nullable: false),
                    BrojZauzetihMjestaZR = table.Column(type: "INTEGER", nullable: false),
                    Cijena = table.Column(type: "REAL", nullable: false),
                    GeoDuzina = table.Column(type: "REAL", nullable: false),
                    GeoSirina = table.Column(type: "REAL", nullable: false),
                    Kapacitet = table.Column(type: "INTEGER", nullable: false),
                    ParkingId = table.Column(type: "INTEGER", nullable: true),
                        //.Annotation("Sqlite:Autoincrement", true),
                    VlasnikParkingaId = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingRezervacija", x => x.ParkingRezervacijaId);
                    table.ForeignKey(
                        name: "FK_ParkingRezervacija_VlasnikParkinga_VlasnikParkingaId",
                        columns: x => x.VlasnikParkingaId,
                        referencedTable: "VlasnikParkinga",
                        referencedColumn: "VlasnikParkingaId");
                });
            migration.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Komentar = table.Column(type: "TEXT", nullable: true),
                    OcjenaP = table.Column(type: "INTEGER", nullable: false),
                    ParkingId = table.Column(type: "INTEGER", nullable: false),
                    ParkingRezervacijaParkingRezervacijaId = table.Column(type: "INTEGER", nullable: true),
                    UserId = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjena_Parking_ParkingId",
                        columns: x => x.ParkingId,
                        referencedTable: "Parking",
                        referencedColumn: "ParkingId");
                    table.ForeignKey(
                        name: "FK_Ocjena_ParkingRezervacija_ParkingRezervacijaParkingRezervacijaId",
                        columns: x => x.ParkingRezervacijaParkingRezervacijaId,
                        referencedTable: "ParkingRezervacija",
                        referencedColumn: "ParkingRezervacijaId");
                    table.ForeignKey(
                        name: "FK_Ocjena_User_UserId",
                        columns: x => x.UserId,
                        referencedTable: "User",
                        referencedColumn: "UserId");
                });
            migration.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    AdministratorAdministratorId = table.Column(type: "INTEGER", nullable: true),
                    Cijena = table.Column(type: "TEXT", nullable: true),
                    KrajRezervacije = table.Column(type: "TEXT", nullable: false),
                    ParkingRezervacijaId = table.Column(type: "INTEGER", nullable: false),
                    PocetakRezervacije = table.Column(type: "TEXT", nullable: false),
                    UserId = table.Column(type: "INTEGER", nullable: false),
                    VlasnikParkingaVlasnikParkingaId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Administrator_AdministratorAdministratorId",
                        columns: x => x.AdministratorAdministratorId,
                        referencedTable: "Administrator",
                        referencedColumn: "AdministratorId");
                    table.ForeignKey(
                        name: "FK_Rezervacija_ParkingRezervacija_ParkingRezervacijaId",
                        columns: x => x.ParkingRezervacijaId,
                        referencedTable: "ParkingRezervacija",
                        referencedColumn: "ParkingRezervacijaId");
                    table.ForeignKey(
                        name: "FK_Rezervacija_User_UserId",
                        columns: x => x.UserId,
                        referencedTable: "User",
                        referencedColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Rezervacija_VlasnikParkinga_VlasnikParkingaVlasnikParkingaId",
                        columns: x => x.VlasnikParkingaVlasnikParkingaId,
                        referencedTable: "VlasnikParkinga",
                        referencedColumn: "VlasnikParkingaId");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Ocjena");
            migration.DropTable("Rezervacija");
            migration.DropTable("Parking");
            migration.DropTable("Administrator");
            migration.DropTable("ParkingRezervacija");
            migration.DropTable("User");
            migration.DropTable("VlasnikParkinga");
        }
    }
}
