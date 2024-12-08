use master;
go

drop database if exists zoo;
go
--kreiram novu bazu
create database zoo;
go

use zoo;
go

create table prostorija(
sifra int not null primary key identity(1,1),
dimenzije varchar(30) not null,
maks_broj int not null,
mjesto varchar(30) not null,
);

create table datum(
d_rodenja datetime not null,
d_dolaska datetime not null,
d_smrti datetime not null,
sifra int not null primary key identity(1,1)
);

create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
iban varchar(50) not null
);

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int references djelatnik(sifra) not null,
prostorija int not null,
datum int references datum(sifra) not null
);

