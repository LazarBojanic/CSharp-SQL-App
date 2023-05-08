﻿**Uputstvo za korišćenje softvera za ugovore Infoplana**

(C# winforms, MS Access database)

Nakon otvaranja programa, korisnik mora uneti svoj username i password koji su podesili kod administratora:

![](Manual-SRB-1.png)

Nakon uspešnog prijavljivanja otvara se glavni meni:

![](Manual-SRB-2.png)

„Detalji“ otvara prozor o detaljima softvera a „Logout“ odjavljuje korisnika i vraća se na „Login“ formu.

Klikom na dugmad „Opštine“  i  „Tipovi Ugovora“ mogu se videti opštine i tipovi ugovora. Funkcionalnosti dodavanja, izmene i brisanja imaju samo administratori: 

![](Manual-SRB-3.png) ![](Manual-SRB-4.png)

Klikom na dugme „Dodaj“ korisnici mogu da dodaju nove opštine, na „Izmeni“ da izmene izabranu opštinu a na „Obriši“ da je obrišu. Izmena takođe može da se izvrši dvoklikom na željeni red. Svako dugme za brisanje u aplikaciji prikazuje prozor za potvrdu. Slični prozori se otvaraju za tipove ugovora.

Sa glavnog menija korisnici mogu da izmene svoj username i password, dok mogućnost menjanja privilegije imaju samo administratori:

![](Manual-SRB-5.png)

Sa glavnog menija administrator mogu da vide sve korisnike i njihove privilegije ali ne I njihove password-e:

![](Manual-SRB-6.png)

Administratori takođe ovde mogu da prave, menjaju i brišu korisnike:

![](Manual-SRB-7.png)

Klikom na dugme izmeni takođe ostavlja prazno polje na mesto passworda, ovo je namenjeno u slučaju da korisnik zaboravi svoj password ili ne može da se uloguje, tada administrator može da stavi novi.

Korisnik može da radi sve osnovne funkcionalnosti, ali ne može da dodaje, menja ili briše tabele opština, tipova ugovora i korisnika za razliku od administratora koji može sve da radi. Turista može samo da gleda tabele i vrši pretragu nad ugovorima.

Sa glavnog menija klikom na dugme „Ugovori“, otvara se forma sa prikazom svih ugovora:

![](Manual-SRB-8.png)

Ugovori su obojeni u skladu sa poljem „usvojen“. Podaci u tabelama na svakoj formi mogu da se sortiraju klikom na ime željene kolone. Korisnici mogu da vrše pretragu ugovora po svim poljima, i da export-uju rezultujuću ili inicijalnu tabelu u željenom Excel formatu: 

![](Manual-SRB-9.png)

 Na svakoj formi sa tabelom, korisnici mogu da desnim klikom kopiraju sadržaj polja ili sadržaj celog reda, odvojenog zarezima, u „Clipboard“. Brojni i datumski podaci mogu se pretraživati sa znakovima poređenja. Klikom na kvadratiće ispred polja za datume se oni uključuju/isključuju iz pretrage. Pretraga se vrši na dugme „Pretraga“ ili klikom na taster „Enter“. Dugme „Osveži“ ponovo učitava celu tabelu. „Istorija Promena“ prikazuje istoriju promena svakog polja za izabrani ugovor koji se bira klikom na red u tabeli:
 
 ![](Manual-SRB-10.png)

„Istorija Promena Obrisanih Ugovora“ radi isto, samo za obrisane ugovore koji se na tabeli ne vide.

„Dodaj“ otvara novu formu gde korisnici mogu da dodaju novi ugovor sa različitim parametrima:

![](Manual-SRB-11.png)

Polja „Opština“, „Tip Ugovora“, „Rok po ugovoru (interval), gde mogu da se izaberu odgovarajuće vrednosti. Polje „Krajnji rok“ se automatski menja u odnosu na datum ugovora u zavisnosti od roka po ugovoru. Klikom na check box „Usvojen“ otkriva ili sakriva polja „Datum usvajanja“ i „Broj službenog vlasnika“. Ako je ovaj check box isključen, ugovor koji se dodaje ili menja će imati vrednost datuma usvajanja 01/01/1970 koji označava nepostojeći datum. Kod svih formi menjanja ili dodavanja, „Sačuvaj“ vrši zadate promene a „Otkaži“ ih odbacuje i ne menja tabele.

Sa forme „Ugovori“, „Izmeni“, otvara istu formu kao i za dodavanje, samo za odabrani ugovor sa forme. Ovde korisnici mogu da menjaju podatke o ugovoru. Otvaranje forme za izmenu takođe može da se izvrši duplim klikom na željeni ugovor. Ako korisnik otvori formu za dodavanje ili izmenu a u među vremenu neki drugi korisnik izvrši promenu nad istim ugovorom, pojavljuje se prozor greške. Ovim se omogućava ispravan rad nad bazom podataka.

Dugme „Obriši“, na formi „Ugovori“, briše odabrani ugovor i ovo mogu samo administratori da rade:

![](Manual-SRB-12.png)

„Fajlovi ugovora“ otvara formu gde su prikazani svi vezani fajlovi i njihove putanje za izabrani ugovor:

Klikom na „Prikaži“ ili duplim klikom na željeni ugovor, otvara se izabrani ugovor u odgovarajućem programu u skladu sa tipom fajla. Klikom na „Dodaj“ otvara se prozor gde može da se izabere jedan željeni fajl za dodavanje:

![](Manual-SRB-13.png)

Na formi „Fajlovi ugovora“ „Ukloni“ briše fajl iz tabele ali ne fajl na disku. Ovo takođe samo administratori mogu da urade.