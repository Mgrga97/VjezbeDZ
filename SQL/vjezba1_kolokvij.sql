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

-- Umetanje podataka
-- Tablica: punac
insert into punac (ogrlica, gustoca, hlace) 
values 
(3, 1634, 'Jeans'),
(5, 2.54, 'Kratke hlače');

-- Tablica: cura
insert into cura (sifra, novcica, gustoca, lipa, ogrlica, bojakose, suknja, punac) 
values 
(1, 107, 2.34, 8273, 1, 'Plava', 'Mini suknja', 1),
(2, 200, 3245.62, 210, 2, 'Smeđa', 'Duga suknja', 2);

-- Tablica: sestra
insert into sestra (introvertno, haljina, maraka, hlace, narukvica)
values 
(1, 'Crvena', 150.21, 'Traperice', 2),
(0, 'Plava', 250.56, 'Kratke', 3);

-- Tablica: zena
insert into zena (treciputa, hlace, kratkamajica, jmbag, bojaociju, haljina, sestra)
values 
('2025-01-19', 'Crne', 'Bijela', '12345678901', 'Smeđa', 'Crvena', 1),
('2025-01-20', 'Plave', 'Zelena', '10987654321', 'Plava', 'Plava', 2);

-- Tablica: muskarac
insert into muskarac (bojaociju, hlace, modelnaocala, maraka, zena)
values 
('Plava', 'Smeđe', 'Ray-Ban', 300, 1),
('Zelena', 'Crne', 'Oakley', 401, 2);

-- Tablica: mladic
insert into mladic (suknja, kuna, drugiputa, asocijalno, ekstroventno, dukserica, muskarac)
values 
('Mini', 109, '2025-01-21', 0, 1, 'Crvena', 1),
('Midi', 200.87, '2025-01-22', 1, 0, 'Zelena', 2);

-- Tablica: svekar
insert into svekar (bojaociju, prstena, dukserica, lipa, eura, majica)
values 
('Plava', 1, 'Crvena', 8, 1067, 'Bijela'),
('Smeđa', 2, 'Plava', 81, 210, 'Crna');

-- Tablica: sestra_svekar
insert into sestra_svekar (sestra, svekar)
values 
(1, 1),
(2, 2);