--create database havayolu

--use havayolu


                                                               --Tablolar Olu�turuldu--


--create table Personeller (

--PersonelID int primary key IDENTITY(1,1),
--PersonelAd nvarchar(30),
--PersonelSoyad nvarchar(30),

--)


--create table musteriler (

--M��teriID int primary key IDENTITY(1,1),
--M��teriAd nvarchar(30) ,
--M��teriSoyad nvarchar(30),
--M��teriTel int ,
--M��teriAdres nvarchar(50),
--M��teriMail nvarchar(35)

--)

--create table SeyehatBilgileri (

--SeyehatID int primary key IDENTITY(1,1),
--Kalk��Yeri nvarchar(50) ,
--Var��Yeri nvarchar(50),
--Kalk��Saati time,
--Gidi�Tarihi smalldatetime,
--D�n��Tarihi smalldatetime,
--S�n�f nvarchar(30),
--KoltukNo int,
--Fiyat float

--)

--create table Sipari�ler (

--Sipari�ID int primary key IDENTITY(1,1),
--Tutar float

--)

--create table FiloBilgileri (

--U�akID int primary key IDENTITY(1,1),
--U�akModeli nvarchar(30),
--U�akAdedi int,
--YolcuKapasitesi int,
--G�vdeUzunlu�u nvarchar(50),

--) 

                                                   --Alter komutu ile eksik kalan alanlar daha sonra eklendi--

--alter table musteriler add M��teriTC int
--alter table SeyehatBilgileri add Ki�iSay�s� int
--alter table SeyehatBilgileri add Var��Saati time




                                                        --tablolara �rnek kay�t ekleme


--INSERT INTO Personeller VALUES('Ali', 'Y�ld�z')


--INSERT INTO musteriler VALUES('Sinem','Kaya',2477841156,05417895478,'Bah�elievler Merkez Mahallesi K�v�lc�m Sokak G�ne� Apt' ,'sinemyildiz@hotmail.com',1)


--INSERT INTO SeyehatBilgileri (MusteriID,Kalk��Yeri,Var��Yeri,Kalk��Saati,Var��Saati,Ki�iSay�s�,Gidi�Tarihi,D�n��Tarihi,S�n�f,KoltukNo,Fiyat)

--VALUES(1,'�stanbul','�zmir','14:30:30','15:30:35',1,'2018-01-25','2018-01-29','Ekonomik',45,'80.5')



--insert into MusteriUcakSeyehatBilgileri (MusteriID,UcakID,SeyahatID,Gidi�Tarih,D�n��Tarih) VALUES(1,1,1,'2018-01-25','2018-01-29')


--alter table Personeller add PersonelTC bigint , PersonelTel bigint, PersonelMail nvarchar(50)


--INSERT INTO Personeller VALUES('Gizem', 'Arslan' , 160457899415 , 5324789547,'Gizemarslan@hotmail.com')


--INSERT INTO Personeller VALUES('Emre', 'Y�lmaz' , 140877415698 , 5445786789,'Emreyiilmaz@gmail.com')


--INSERT INTO Personeller VALUES('Mehmet', 'Sunkur' , 26547899654 , 5314789547,'Mehmetsunkuur@hotmail.com')


--UPDATE Personeller SET PersonelTC=14087741569 where PersonelID=3


--INSERT INTO Personeller VALUES('Selda', 'Yener' , 14557899547 , 5321547898,'SeldaYenerr@hotmail.com')


--INSERT INTO FiloBilgileri VALUES('A319-132',15,130,33.84)


--alter table FiloBilgileri Add YerdenY�ksekli�i nvarchar(30), KanatA��kl��� nvarchar(30),AzamiKalk��A��rl��� nvarchar(30),AzamiKargoKapasitesi nvarchar(50)


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

--alter table SeyehatBilgileri add M��teriSoyad nvarchar(30)

--alter table SeyehatBilgileri add U�akNo nvarchar(30)

--alter table SeyehatBilgileri add BiletKodu nvarchar(30)


--insert into SeyehatBilgileri ( MusteriID, M��teriSoyad , U�akNo , BiletKodu,Kalk��Yeri,Var��Yeri,Kalk��Saati,
--Var��Saati,Ki�iSay�s�,Gidi�Tarihi,D�n��Tarihi,S�n�f,KoltukNo,Fiyat)
--VALUES (1,'Kaya','1','AS47854BC9','�stanbul','�zmir','14:30:30','15:30:30',1,'2018-01-25','2018-01-29','Ekonomik',45,'80.50')



                                                                           