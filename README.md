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
Araba günlük fiyatý 0'dan büyük olmalýdýr.
Ödevinize ait github linkini paylaþýnýz.