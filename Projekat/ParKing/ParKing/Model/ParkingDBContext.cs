using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ParKing.Model
{
    public class ParkingDBContext : DbContext
    {
        public DbSet<Parking> Parkingzi { get; set; }
        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<User> Useri { get; set; }
        public DbSet<ParkingRezervacija> ParkingRezervacija { get; set; }
        public DbSet<VlasnikParkinga> Vlasnici { get; set; }
        public DbSet<Ocjena> Ocjene { get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }

        //Metoda koja će promijeniti konfiguraciju i odrediti gdje se spašava klasa i kako se zove.
        //Ovisno od uređaja spasiti će se na različite lokacije, za desktop se kreira poseban folder u AppData/Local Folderu od korisnika
        //Svaki korisnik koji pokrene aplikaciju će imati kreiranu bazu lokalno kod sebe
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Parking.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        
    }
}
