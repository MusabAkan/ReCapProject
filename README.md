# ReCapProject

�dev 2
Kamp�m�zla beraber paralelde geli�tirece�imiz bir projemiz daha olacak. Araba kiralama sistemi yaz�yoruz.
Yepyeni bir proje olu�turunuz. Ad� ReCapProject olacak. (Tekrar ve geli�tirme projesi)
Entities, DataAccess, Business ve Console katmanlar�n� olu�turunuz.
Bir araba nesnesi olu�turunuz. "Car"
�zellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlar�n� ekleyiniz. (Brand = Marka)
InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlar�n� yaz�n�z.
Consolda test ediniz.
�nemli: Copy-Paste yasak fakat kamp projesinden destek almak serbest.
Kodlar�n�z� Github'a aktar�p payla��n�z. �nceledi�iniz arkada�lar�n�za y�ld�z vermeyi unutmay�n�z.

�dev 3 
Araba Kiralama projemiz �zerinde �al��maya devam edece�iz.
Car nesnesine ek olarak;
1) Brand ve Color nesneleri ekleyiniz(Entity)
Brand-->Id,Name
Color-->Id,Name
2) Sql Server taraf�nda yeni bir veritaban� kurunuz. Cars,Brands,Colors tablolar�n� olu�turunuz. (Ara�t�rma)
3) Sisteme Generic IEntityRepository altyap�s� yaz�n�z.
4) Car, Brand ve Color nesneleri i�in Entity Framework altyap�s�n� yaz�n�z.
5) GetCarsByBrandId , GetCarsByColorId servislerini yaz�n�z.
6) Sisteme yeni araba eklendi�inde a�a��daki kurallar� �al��t�r�n�z.
Araba ismi minimum 2 karakter olmal�d�r
Araba g�nl�k fiyat� 0'dan b�y�k olmal�d�r.�4567
�devinize ait github linkini payla��n�z. 

�dev 4
Not : �steyenler Northwind projesindeki Core katman�n� da ekleyebilir ama peki�tirmek i�in yeniden yazman�z� �neririm. Bu �ekilde yapmak isteyenler CarRental/Solution Explorer Sa� T�k / Add /Existing Project/ Northwind i�indeki Core klas�r�nde Core.csproj dosyas�n� ekleyebilirler. Bu �ekilde yapanlar a�a��daki 3. ad�mdan devam edebilirler.
�nerim a�a��daki gibi yeniden yapman�zd�r.
CarRental Projenizde Core katman� olu�turunuz.
IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalar�n�z� 9. g�n dersindeki gibi olu�turup ekleyiniz.
Car, Brand, Color s�n�flar�n�z i�in t�m CRUD operasyonlar�n� haz�r hale getiriniz.
Console'da T�m CRUD operasyonlar�n�z� Car, Brand, Model nesneleriniz i�in test ediniz. GetAll, GetById, Insert, Update, Delete.
Arabalar� �u bilgiler olacak �ekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (�pucu : IDto olu�turup 3 tabloya join yaz�n�z)
Kodlar�n�z� Github hesab�n�zda payla��p link veriniz.
Ba�kalar�n�n kodlar�n� inceleyiniz. Be�enirseniz y�ld�z veriniz.
