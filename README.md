# ReCapProject

Ödev 2
Kampýmýzla beraber paralelde geliþtireceðimiz bir projemiz daha olacak. Araba kiralama sistemi yazýyoruz.
Yepyeni bir proje oluþturunuz. Adý ReCapProject olacak. (Tekrar ve geliþtirme projesi)
Entities, DataAccess, Business ve Console katmanlarýný oluþturunuz.
Bir araba nesnesi oluþturunuz. "Car"
Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarýný ekleyiniz. (Brand = Marka)
InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarýný yazýnýz.
Consolda test ediniz.
Önemli: Copy-Paste yasak fakat kamp projesinden destek almak serbest.
Kodlarýnýzý Github'a aktarýp paylaþýnýz. Ýncelediðiniz arkadaþlarýnýza yýldýz vermeyi unutmayýnýz.

Ödev 3 
Araba Kiralama projemiz üzerinde çalýþmaya devam edeceðiz.
Car nesnesine ek olarak;
1) Brand ve Color nesneleri ekleyiniz(Entity)
Brand-->Id,Name
Color-->Id,Name
2) Sql Server tarafýnda yeni bir veritabaný kurunuz. Cars,Brands,Colors tablolarýný oluþturunuz. (Araþtýrma)
3) Sisteme Generic IEntityRepository altyapýsý yazýnýz.
4) Car, Brand ve Color nesneleri için Entity Framework altyapýsýný yazýnýz.
5) GetCarsByBrandId , GetCarsByColorId servislerini yazýnýz.
6) Sisteme yeni araba eklendiðinde aþaðýdaki kurallarý çalýþtýrýnýz.
Araba ismi minimum 2 karakter olmalýdýr
Araba günlük fiyatý 0'dan büyük olmalýdýr.ü4567
Ödevinize ait github linkini paylaþýnýz. 

Ödev 4
Not : Ýsteyenler Northwind projesindeki Core katmanýný da ekleyebilir ama pekiþtirmek için yeniden yazmanýzý öneririm. Bu þekilde yapmak isteyenler CarRental/Solution Explorer Sað Týk / Add /Existing Project/ Northwind içindeki Core klasöründe Core.csproj dosyasýný ekleyebilirler. Bu þekilde yapanlar aþaðýdaki 3. adýmdan devam edebilirler.
Önerim aþaðýdaki gibi yeniden yapmanýzdýr.
CarRental Projenizde Core katmaný oluþturunuz.
IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarýnýzý 9. gün dersindeki gibi oluþturup ekleyiniz.
Car, Brand, Color sýnýflarýnýz için tüm CRUD operasyonlarýný hazýr hale getiriniz.
Console'da Tüm CRUD operasyonlarýnýzý Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
Arabalarý þu bilgiler olacak þekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (Ýpucu : IDto oluþturup 3 tabloya join yazýnýz)
Kodlarýnýzý Github hesabýnýzda paylaþýp link veriniz.
Baþkalarýnýn kodlarýný inceleyiniz. Beðenirseniz yýldýz veriniz.

Ödev -5 
Core katmanýnda Results yapýlandýrmasý yapýnýz.
Daha önce geliþtirdiðiniz tüm Business sýnýflarýný bu yapýya göre refactor (kodu iyileþtirme) ediniz

Ödev -6

Kullanýcýlar tablosu oluþturunuz. Users-->Id,FirstName,LastName,Email,Password
Müþteriler tablosu oluþturunuz. Customers-->UserId,CompanyName
*****Kullanýcýlar ve müþteriler iliþkilidir.
Arabanýn kiralanma bilgisini tutan tablo oluþturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemiþse ReturnDate null'dýr.
Projenizde bu entity'leri oluþturunuz.
CRUD operasyonlarýný yazýnýz.
Yeni müþteriler ekleyiniz.
Arabayý kiralama imkanýný kodlayýnýz. Rental-->Add
Arabanýn kiralanabilmesi için arabanýn teslim edilmesi gerekmektedir.

Ödev -7

Car Rental Projenize Autofac, FluentValidation ve AOP  desteði ekleyiniz.

 
