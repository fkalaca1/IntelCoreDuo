using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ParKing.Model;

namespace ParKingMigrations
{
    [ContextType(typeof(ParkingDBContext))]
    partial class ParkingDBContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("ParKing.Model.Administrator", b =>
                {
                    b.Property<int>("AdministratorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojTelefona");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("Sifra");

                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Key("AdministratorId");
                });

            builder.Entity("ParKing.Model.Ocjena", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Komentar");

                    b.Property<int>("OcjenaP");

                    b.Property<int>("ParkingId");

                    b.Property<int?>("ParkingRezervacijaParkingRezervacijaId");

                    b.Property<int>("UserId");

                    b.Key("OcjenaId");
                });

            builder.Entity("ParKing.Model.Parking", b =>
                {
                    b.Property<int>("ParkingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<double>("Cijena");

                    b.Property<double>("GeoDuzina");

                    b.Property<double>("GeoSirina");

                    b.Property<int>("Kapacitet");

                    b.Property<int?>("VlasnikParkingaVlasnikParkingaId");

                    b.Key("ParkingId");
                });

            builder.Entity("ParKing.Model.ParkingRezervacija", b =>
                {
                    b.Property<int>("ParkingRezervacijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int>("BrojMjestaZR");

                    b.Property<string>("BrojTelefona");

                    b.Property<int>("BrojZauzetihMjesta");

                    b.Property<int>("BrojZauzetihMjestaZR");

                    b.Property<double>("Cijena");

                    b.Property<double>("GeoDuzina");

                    b.Property<double>("GeoSirina");

                    b.Property<int>("Kapacitet");

                    b.Property<int>("ParkingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("VlasnikParkingaId");

                    b.Key("ParkingRezervacijaId");
                });

            builder.Entity("ParKing.Model.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AdministratorAdministratorId");

                    b.Property<string>("Cijena");

                    b.Property<DateTime>("KrajRezervacije");

                    b.Property<int>("ParkingRezervacijaId");

                    b.Property<DateTime>("PocetakRezervacije");

                    b.Property<int>("UserId");

                    b.Property<int?>("VlasnikParkingaVlasnikParkingaId");

                    b.Key("RezervacijaId");
                });

            builder.Entity("ParKing.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojTelefona");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("Sifra");

                    b.Key("UserId");
                });

            builder.Entity("ParKing.Model.VlasnikParkinga", b =>
                {
                    b.Property<int>("VlasnikParkingaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojTelefona");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("Sifra");

                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Key("VlasnikParkingaId");
                });

            builder.Entity("ParKing.Model.Ocjena", b =>
                {
                    b.Reference("ParKing.Model.Parking")
                        .InverseCollection()
                        .ForeignKey("ParkingId");

                    b.Reference("ParKing.Model.ParkingRezervacija")
                        .InverseCollection()
                        .ForeignKey("ParkingRezervacijaParkingRezervacijaId");

                    b.Reference("ParKing.Model.User")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });

            builder.Entity("ParKing.Model.Parking", b =>
                {
                    b.Reference("ParKing.Model.VlasnikParkinga")
                        .InverseCollection()
                        .ForeignKey("VlasnikParkingaVlasnikParkingaId");
                });

            builder.Entity("ParKing.Model.ParkingRezervacija", b =>
                {
                    b.Reference("ParKing.Model.VlasnikParkinga")
                        .InverseCollection()
                        .ForeignKey("VlasnikParkingaId");
                });

            builder.Entity("ParKing.Model.Rezervacija", b =>
                {
                    b.Reference("ParKing.Model.Administrator")
                        .InverseCollection()
                        .ForeignKey("AdministratorAdministratorId");

                    b.Reference("ParKing.Model.ParkingRezervacija")
                        .InverseCollection()
                        .ForeignKey("ParkingRezervacijaId");

                    b.Reference("ParKing.Model.User")
                        .InverseCollection()
                        .ForeignKey("UserId");

                    b.Reference("ParKing.Model.VlasnikParkinga")
                        .InverseCollection()
                        .ForeignKey("VlasnikParkingaVlasnikParkingaId");
                });
        }
    }
}
