
create database knjizara;
go

use knjizara;
go
-- kreiranje tablice osobe
create table osobe(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
adresa varchar(50),
email varchar(50)

);
--kreiranje tablice knjige
create table knjige(
sifra int not null primary key identity(1,1),
naslov varchar(50),
pisac varchar(50),
vlasnik int not null,
clan int not null,
datum_posudivanja datetime,
datum_vracanja datetime,
foreign key (vlasnik) references osobe(sifra),
foreign key (clan) references clan (sifra)

);

create table clan(
sifra int not null primary key identity(1,1),
clanski_broj int not null

);

create table vlasnik(
sifra int not null primary key identity(1,1),
knjiga int not null 
foreign key (knjiga) references knjige(sifra)

);