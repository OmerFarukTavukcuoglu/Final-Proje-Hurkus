--create database havayolu

--use havayolu


                                                               --Tablolar Oluþturuldu--


--create table Personeller (

--PersonelID int primary key IDENTITY(1,1),
--PersonelAd nvarchar(30),
--PersonelSoyad nvarchar(30),

--)


--create table musteriler (

--MüþteriID int primary key IDENTITY(1,1),
--MüþteriAd nvarchar(30) ,
--MüþteriSoyad nvarchar(30),
--MüþteriTel int ,
--MüþteriAdres nvarchar(50),
--MüþteriMail nvarchar(35)

--)

--create table SeyehatBilgileri (

--SeyehatID int primary key IDENTITY(1,1),
--KalkýþYeri nvarchar(50) ,
--VarýþYeri nvarchar(50),
--KalkýþSaati time,
--GidiþTarihi smalldatetime,
--DönüþTarihi smalldatetime,
--Sýnýf nvarchar(30),
--KoltukNo int,
--Fiyat float

--)

--create table Sipariþler (

--SipariþID int primary key IDENTITY(1,1),
--Tutar float

--)

--create table FiloBilgileri (

--UçakID int primary key IDENTITY(1,1),
--UçakModeli nvarchar(30),
--UçakAdedi int,
--YolcuKapasitesi int,
--GövdeUzunluðu nvarchar(50),

--) 

                                                   --Alter komutu ile eksik kalan alanlar daha sonra eklendi--

--alter table musteriler add MüþteriTC int
--alter table SeyehatBilgileri add KiþiSayýsý int
--alter table SeyehatBilgileri add VarýþSaati time




                                                        --tablolara örnek kayýt ekleme


--INSERT INTO Personeller VALUES('Ali', 'Yýldýz')


--INSERT INTO musteriler VALUES('Sinem','Kaya',2477841156,05417895478,'Bahçelievler Merkez Mahallesi Kývýlcým Sokak Güneþ Apt' ,'sinemyildiz@hotmail.com',1)


--INSERT INTO SeyehatBilgileri (MusteriID,KalkýþYeri,VarýþYeri,KalkýþSaati,VarýþSaati,KiþiSayýsý,GidiþTarihi,DönüþTarihi,Sýnýf,KoltukNo,Fiyat)

--VALUES(1,'Ýstanbul','Ýzmir','14:30:30','15:30:35',1,'2018-01-25','2018-01-29','Ekonomik',45,'80.5')



--insert into MusteriUcakSeyehatBilgileri (MusteriID,UcakID,SeyahatID,GidiþTarih,DönüþTarih) VALUES(1,1,1,'2018-01-25','2018-01-29')


--alter table Personeller add PersonelTC bigint , PersonelTel bigint, PersonelMail nvarchar(50)


--INSERT INTO Personeller VALUES('Gizem', 'Arslan' , 160457899415 , 5324789547,'Gizemarslan@hotmail.com')


--INSERT INTO Personeller VALUES('Emre', 'Yýlmaz' , 140877415698 , 5445786789,'Emreyiilmaz@gmail.com')


--INSERT INTO Personeller VALUES('Mehmet', 'Sunkur' , 26547899654 , 5314789547,'Mehmetsunkuur@hotmail.com')


--UPDATE Personeller SET PersonelTC=14087741569 where PersonelID=3


--INSERT INTO Personeller VALUES('Selda', 'Yener' , 14557899547 , 5321547898,'SeldaYenerr@hotmail.com')


--INSERT INTO FiloBilgileri VALUES('A319-132',15,130,33.84)


--alter table FiloBilgileri Add YerdenYüksekliði nvarchar(30), KanatAçýklýðý nvarchar(30),AzamiKalkýþAðýrlýðý nvarchar(30),AzamiKargoKapasitesi nvarchar(50)


--INSERT INTO FiloBilgileri VALUES('A340-300',4,354,'63,68m','16,99m','60,30m','257,000kg','44.836kg')


--INSERT INTO FiloBilgileri VALUES('A330-300',37,305,'63,69m','17,40m','60,30m','230,000kg','37.578kg')


--INSERT INTO FiloBilgileri VALUES('A330-200',16,220,'58,80m','17,40m','60,30m','233,000kg','37.578kg')


--INSERT INTO FiloBilgileri VALUES('A321-200',68,178,'44,51m','11,76m','34,09m','89,000kg','12.837kg')


--INSERT INTO FiloBilgileri VALUES('A320-200',24,159,'37,57m','11,91m','33,91m','77,000kg','31.64kg')


--INSERT INTO FiloBilgileri VALUES('A319-132/100',7,132,'33,84m','11,76m','34,10m','70,000kg','27.62kg')


--INSERT INTO FiloBilgileri VALUES('B777-300ER',35,349,'73,90m','18,60m','64,80m','351,534kg','57.784kg')


--INSERT INTO FiloBilgileri VALUES('B737-700',1,124,'33,60m','12,57m','35,80m','70,080kg','4.178kg')


--INSERT INTO FiloBilgileri VALUES('B737-900ER',15,169,'42,10m','12,50m','35,80m','85,139kg','44kg')


--use havayolu

--alter table SeyehatBilgileri add MüþteriSoyad nvarchar(30)

--alter table SeyehatBilgileri add UçakNo nvarchar(30)

--alter table SeyehatBilgileri add BiletKodu nvarchar(30)


--insert into SeyehatBilgileri ( MusteriID, MüþteriSoyad , UçakNo , BiletKodu,KalkýþYeri,VarýþYeri,KalkýþSaati,
--VarýþSaati,KiþiSayýsý,GidiþTarihi,DönüþTarihi,Sýnýf,KoltukNo,Fiyat)
--VALUES (1,'Kaya','1','AS47854BC9','Ýstanbul','Ýzmir','14:30:30','15:30:30',1,'2018-01-25','2018-01-29','Ekonomik',45,'80.50')



                                                                           