using System.Security.Cryptography;

namespace Core.Utilities.Constants
{
    public static class Messages
    {
        public static string ImageNotUpload = "Resim güncellenmemiştir.";
        public static string ImageUpdated = "Resim güncellenmiştir.";
        public static string MustGreaterThanZero = "Arabanın günlük fiyatı 0'dan büyük olmalıdır.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string CustomerNotFound = "Müşteri bulunamadı";
        public static string Deleted = "Sistemden veri silinmiştir.";
        public static string Added = "Sisteme veri eklenmiştir.";
        public static string Updated = "Sisteme veri güncellenmiştir.";
        public static string Listed = "Veriler listelenmiştir.";
        public static string NotFoundCar = "Sistemde seçtiğiniz araba kayıtlı değil";
        public static string MustCarFiveImage = "Bir arabanın en fazla 5 resmi olabilir.";
        public static string NotFoundAddres = "Addres yok.";
        public static string RemovedImageFile = "Dosya kaldırılmıştır.";
        public static string NotFoundImageFile = "Dosya yok veya bulunamadı";
        public static string NotFoundSelectFile = "Dosya seçilmedi yada boş!!";
        public static string MaxFileCount = "Dosya boyutu aşılmıştır.";
        public static string NotFormatFile = "Dosya uygun formatta değildir.";
        public static string? AuthorizationDenied = "Yetkiniz Yok!!";

       
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
