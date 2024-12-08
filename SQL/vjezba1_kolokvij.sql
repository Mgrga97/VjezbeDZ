use master;
go

drop database if exists vjezba1kolokvij;
go

create database vjezba1kolokvij;
go

use vjezba1kolokvij;
go

create table punac(
sifra int not null primary key identity(1,1),
ogrlica int not null,
gustoca decimal(14,9),
hlace varchar(50)not null

);

create table cura(
sifra int not null,
novcica decimal(16,5),
gustoca decimal(18,6),
lipa decimal (13,10),
ogrlica int not null references punac(sifra), 
bojakose varchar(50),
suknja varchar(50)not null,
punac int not null

);

create table sestra(
sifra int not null primary key identity(1,1),
introvertno bit,
haljina varchar(50)not null,
maraka decimal(16,6),
hlace varchar(50)not null,
narukvica int not null

);

create table zena(
sifra int not null primary key identity(1,1),
treciputa datetime,
hlace varchar(50)not null,
kratkamajica varchar(50)not null,
jmbag char(11),
bojaociju varchar(50)not null,
haljina varchar(50)not null,
sestra int not null references sestra(sifra)
);



create table muskarac(
sifra int not null primary key identity(1,1),
bojaociju varchar(50)not null,
hlace varchar(50)not null,
modelnaocala varchar(50)not null,
maraka decimal(14,5),
zena int not null references zena(sifra)

);

create table mladic(
sifra int not null primary key identity(1,1),
suknja varchar(50) not null,
kuna decimal(16, 8),
drugiputa datetime,
asocijalno bit,
ekstroventno bit,
dukserica varchar(48)not null,
muskarac int not null references muskarac(sifra)

);

create table svekar(
sifra int not null primary key identity(1,1),
bojaociju varchar(50)not null,
prstena int not null,
dukserica varchar(50)not null,
lipa decimal(13,8),
eura decimal(12,7),
majica varchar(50)not null,

);

create table sestra_svekar(
sifra int not null primary key identity(1,1),
sestra int not null references sestra(sifra),
svekar int not null references svekar(sifra)
);
