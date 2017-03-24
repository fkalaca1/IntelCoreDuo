# IntelCoreDuo

<p align="center">
  <img src ="https://github.com/ooad-2016-2017/IntelCoreDuo/blob/master/logo.png"/>
</p>


## ParKING

### Clanovi Tima:
1. Aldo Selimovic
2. Selmir Šatrovic
3. Tarik Ahmetovic

## Opis Teme

Svakodnevno stotine vozaca se suocava sa problemom pronalaska idealnog parkinga za svoje vozilo. Nas
sistem rjesava taj problem i pruza efikasan I brz nacin pronalaska idealnog parkinga.

Korisnik ima mogucnost pregleda svih parkinga u svojoj okolini, odabirom odredjenog parkinga dobija
detaljne informacije o cjeni parkinga, radnom vremenu, kapacitetu, udaljenosti, sigurnosti, broju
slobodnih mjesta, ocjeni I mogucnosti rezervacije. Ukoliko parking pruza mogucnost rezervacije korisnik
izabere odredjeni vremenski period, sistem proracuna iznos koji treba platiti I placanjem tog iznosa
korisnik ima zagarantovano mjesto na parkingu.

Nas sistem je pogodan za vlasnike parkinga I oni bi ga koristili jer im pruza bolji uvid u poslovanje,
sigurnost, ustedu vremena I mogucnost promovisanja parkinga. Isto tako nas sistem vlasnicima parkinga
daje detaljne izvjestaje o prometu i profitu parkinga.


## Procesi

Korisnik je u mogucnosti da prilikom pokretanja aplikacije obave registraciju ako ne posjeduju profil.

Ako korisnik posjeduje profil mogu se prijaviti na sistem.

Prijava vlasnika parkinga (On posjeduje dodatne forme za mogucnost uvida u statistike parkinga).

Korisnik je u mogucnosti da izvrsi pregled svih parkinga u Sarajevu,prijavljeni korisnik je u mogucnosti da izvrsi rezervaciju parkinga i nakon koristenja parkinga je u mogucnosti i da ga ocjeni.

Sistem na parkingu pomocu kamere azurira stanje na parkingu i salje informacije na server, na osnovu kojih korisnici naseg sistema imaju uvid u stanje parkinga u sarajevu i mogucnosti za rezervaciju.


### Registracija I prijava korisnika:

Korisnik je u mogucnosti da prilikom pokretanja aplikacije obavi registraciju (ukoliko ne posjeduje profil).
Korisnik se registruje tako sto unosi licne podatke kao sto su ime, prezime, email adresa i password ili
preko Google+ profila. Ako korisnik posjeduje profil moze se prijaviti na sistem preko emaila I
passworda. Prijavom na sistem korisnik moze dodati jos informacija o sebi (slika, broj telefona, adresa
itd).

### Pregled I rezervacija parkinga
Korisnik je u mogucnosti da izvrsi pregled svih parkinga u Sarajevu, i tako dobiti detaljne informacije o
svakom parkingu dok prijavljeni korisnik pored mogucnosti pregleda ima i mogucnost rezervacije
parkinga i nakon koristenja parkinga je u mogucnosti i da ga ocjeni.

### Azuriranje stanja na parkingu
Sistem na parkingu pomocu kamere azurira stanje na parkingu i salje informacije na server, na osnovu
kojih korisnici naseg sistema imaju uvid u stanje parkinga u sarajevu i mogucnosti za rezervaciju.

### Prikaz detaljnih izvjestaja za vlasnike

Vlasnik parkinga moze izabrati vremenski period za koji zeli dobiti izvjestaj o prometu ili profitu parkiga.


## Funkcionalnosti

- Mogucnost registracije korisnika.
- Mogucnost pregleda svih parkinga u Sarajevu preko mape ili liste.
- Mogucnost rezervacije parkinga za registrovane korisnike.
- Mogucnost ocjenjivanja parkinga za registrovane korisnike.
- Mogucnost skupljanja poena za besplatan parking.
- Mogucnost pracenja stanja parkinga.
- Mogucnost prijave u sistem sa razlicitim privilegijama.
- Mogucnost prikazivanja detaljnih izvjestaja za vlasnike parkinga.
- Koristenje kamere kao eksternog uredaja(za detekciju pokreta).
- Koristenje Google mape i GPS-a.
- Mogucnost placanja preko mobilnog uredjaja.

## Akteri

### Korisnik usluga

Ima mogucnost pregleda svih parkinga u Sarajevu I mogucnost rezervacije parkinga
(ako je prijavljen na sistem).

###  Radnik/Cuvar parkinga 

Radi na poslovima naplate i evidencije dolaska/odlaska korisnika koji je
rezervisao parking

### Vlasnik parkinga 

Ima uvid u stanje I pristup svim izvjestajima parkinga.