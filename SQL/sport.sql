
use master;
go

drop database if exists sport;
go

create database sport;
go

use sport;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan datetime not null,
stadion varchar(50) not null,
predsjednik varchar(50),
drzava varchar(50),
liga varchar(50)
);

create table utakmica(
sifra int identity (1,1) primary key,
datum date not null,
vrijeme time not null,
lokacija varchar(50),
stadion varchar(50),
domaci_klub int,
gostujuci_klub int,
foreign key (domaci_klub) references klub(sifra),
foreign key (gostujuci_klub) references klub(sifra)

);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datum_rodenja datetime not null,
pozicija varchar(50) not null,
broj_dresa int not null,
klub int not null 
foreign key (klub) references klub(sifra)
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
klub int not null,
nacionalnost varchar(50) not null,
iskustvo int not null,
foreign key (klub) references klub(sifra)
);

