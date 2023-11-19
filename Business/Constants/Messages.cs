using Entities.Concrete;
using Entities.DTOs;

namespace Business.Constants
{
    public class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Arabalar listelendi";

        public static string RentalAdded = "Kiralama işlemi eklendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalDateNull = "Dönüş tarihi belirsiz!";
        public static string RentalsListed = "Kiralama işlemleri listelendi";
        public static string BrandIsNull = "Girilen Id'de bir marka yok";

        public static string BrandsListed = "Markalar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandIdListed = "Id'si girilen marka listelendi";

        public static string ColorsListed = "Renkler listelendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorIdListed = "Id'si girilen renk listelendi";
        public static string ColorIsNull = "Girilen Id'de bir renk yok";

        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string CarImagesListed = "Araba resimleri listelendi";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";

        public static string CarNameAlreadyExists = "Bu isimde zaten başka bir araba var";
        public static string CarImageLimitexceded = "Araba resmi limiti aşıldı";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Sisteme giriş başarılı";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string PaymentUpdated = "Güncellendi";
        public static string PaymentDeleted = "Silindi";
        public static string PaymentAdded = "Ödeme işlemi başarıyla tamamlandı";
        public static string PaymentsListed = "Ödemeler listelendi";
        public static string PayIsSuccessfull = "Ödeme başarılı";

        public static string RentalNotFound = "Kiralama kaydı bulunamadı";
        public static string CarWasRentedByElse = "bu araç başkası tarafından kiralanmış";
        public static string CardInformationIsIncorrect = "Kart bilgileri yanlış";
        public static string CarNotFound = "Araba bulunamadı";
        public static string FindexScoreIsNotEnough = "Findex puanı yetersiz, araç kiralanamıyor";
        public static string CarNotFoundCriteria = "Bu kriterde bir araç bulunmamaktadır.";
        public static string ThisMailAlreadyUse = "Bu mail zaten kullanılıyor";
        public static string MailNotFound = "Mail bulunamadı";
        public static string PasswordUpdated = "Şifre güncellendi";
        public static string OldPasswordError = "Eski şifre hatalı";
    }
}
