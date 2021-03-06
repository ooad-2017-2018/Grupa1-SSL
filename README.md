# Grupa1 - TeamHNS

:busts_in_silhouette: Članovi tima:

1.Ajdinović Haris

2.Bejtić Samra

3.Biševac Nežla


## :sparkles: :sparkles: Sarajevo Social Life :sparkles: :sparkles:


![giphy](https://user-images.githubusercontent.com/37189397/37556734-4f201432-29fa-11e8-9741-1105968de6ce.gif)


SSL je sistem koji pojednostavljuje posjetu društveno-kulturnim dešavanjima u Sarajevu. S obzirom na to će kupovina karti putem ovog sistema biti elektronska, doći će do smanjenja radne snage, odnosno, neće biti potreban veliki broj box office-a. Prednost SSL je odabir dešavanja u Sarajevu putem godišnjih doba, pri čemu će svaki događaj biti opisan, kako bi klijenti imali bolju orijentaciju o događajima, te na osnovu toga zaključili šta im najviše odgovara za posjećivanje. 

Neki od događaja su: 

:snowflake: *Zima*: Sarajevska zima, Zimski salon knjige; 

:tulip: *Proljeće*: Festival osmijeha, Međunarodni sajam knjige;

:sunny: *ljeto*: SFF, Baščaršijske noći; 

:maple_leaf: *Jesen*: MESS, Balet Fest Sarajevo, Jazz Fest Sarajavo. 

Osim događaja koji su navedeni i koji su fiksni, uzeti ćemo u obzir dešavanja u pozorištima, kinima, kao i koncertne manifestacije. 
Lokacija svakog događaja će biti označena na Google mapi kako bi korisnici lakše pronašli traženu lokaciju.
Također korisnicima će biti omogućen pregled caffea/ restorana/ bistroa preko Google mape u okolini navedenih događaja.

Svaki korisnik će morati imati svoj korisnički račun kako bi izvršio kupovinu jedne ili više karata.
Klijenti, uz pomoć sistema biraju godišnje doba koje ih zanima ili koje je na pomolu, potom biraju mjesto u dvorani (cijene karata zavise od pozicije sjedišta u odnosu na binu), te ukoliko su sigurni u svoj odabir rezervišu ili kupuju kartu. Ukoliko je klijent odabrao opciju da kupi kartu odmah, i ukoliko je to 2 mjeseca (ili više) prije koncerta obračunava mu se popust 5%. Ukoliko je rezervisao kartu morati će je preuzeti najkasnije 7 dana prije koncerta, u suprotnom se poništava rezervacija. Ukoliko dođe do automatskog poništavanja rezervacija više od 3 puta, korisnički profil se briše, odnosno, navedeni korisnik neće imati pristup sistemu.

Administrator sistema vrši zakazivanje i otkazivanje događaja.

## Procesi


**Registracija**
```
Omogućava korisniku kreiranje naloga na ovom sistemu.

```

**Log in**
```
Omogućava korisniku pristup korisnikčkom računu koji je već unaprijed otvoren.
```

**Rezervacija**
```
Korisnici koji su registrovani na sistem moći će putem ove opcije rezervisati karte za neki od događaja.
```

**Kupovina karte**

**Otkazivanje rezervacije**
```
Ukoliko korisnik ne može prisustvovati događaju za koji je rezervisao karte, onda on mora otkazati svoju rezervaciju 

najkasnije 7 dana prije eventa.

Ukoliko korisnik nije izvršio uplatu za rezervisane karte najkasnije 7 dana prije događaja, administratori 

sistema će izvršiti otkazivanje rezervacije.
```

**Brisanje korisnika**
```
Ukoliko dođe do automatskog poništavanja rezervacije više od 3 puta od strane istog korisnika, administratori 

brišu datog korsnika sa sistema.
```
**Zakazivanje događaja**

**Brisanje događaja**
```
Ukoliko dođe do otkazivanja nekog događaja, taj događaj će se izbaciti sa sistema.
```

## Funkcionalnosti

* FUNKCIONALNOSTI OD STARNE KORISNIKA 
  * Odabir jezika - Korisnik bira jezik koji mu najviše odgovara. Planirani su slijedeći ponuđeni jezici: bosanski/hrvatski/srpski,         engleski.
  
  * Odabir godišnjeg doba

  * Rezervacija karte
  
  * Registracija na sistem - Korisnik se registruje na sistem tako što ispuni slijedeća polja (sva polja su obavezna) :

    1.Ime

    2.Prezime

    3.Datum rođenja

    4.JMBG

    5.Zanimanje

    6.Spol

    7.Username

    8.Password

    Također, registracija korisnika koji imaju ispod 18 godina neće biti moguća.

  * Kupovina karte
  
   Korisnici koji su registrovani na sistem moći će putem ove opcije kupiti karte za događaje koji ih interesuju, 
   pri čemu se plaćanje vrši elektronskim putem i svaka karta ima svoj jedinstveni QR kod.
  
  * Otkazivanje karte

  * Prikaz lokacije na mapi

  * Elektronsko plaćanje sa eventualnim popustom

* FUNKCIONALNOSTI OD STRANE ADMINA
  * Vođenje evidencije o raspoloživim kartama

  * Brisanje korisnika i događaja sa sistema
  
  * Nadgledanje sistema
  
* FUNKCIONALNOSTI OD STRANE ORGANIZATORA
  * Zakazivanje i otkazivanje događaja
 

## Akteri

1. Klijent sistema je osoba koja želi da pregleda događaje u Sarajevu

2. Klijent sistema koji želi da kupi/rezerviše kartu

3. Administrator vodi evidenciju o događajima i aktivnosti korisnika

4. Organizator vodi evidenciju o događajima
