using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded_TR_tr = "Ürün Eklendi!";
        public static string ProductInvaildName = "Ürün İsmi Geçersiz!";
        public static string MaintenanceTime = "Bakımdayız!";
        public static string ProductListed = "Ürünler Listelendi!";
        public static string UnitPriceInvalid = "Fiyat Geçersiz!";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Bulunabilir.";
        public static string ProductNameAlreadyExists = "Bu İsimde Bir Ürün Zaten Var!";
        public static string CategoryLimitExeded = "Kategori Limiyi Aşıldığı İçin Yeni Ürün Eklenemiyor!";
        public static string AuthorizationDenied = "Yetkilendirme Red!";
        internal static string SuccessfulLogin = "Giriş Başarılı";
        internal static string UserAlreadyExists = "Zaten Bu Kullanıcı Var";
        internal static string AccessTokenCreated = "Token Oluşturma Başarılı!";
        internal static string UserRegistered = "Kayıt Oldu!";
        internal static string PasswordError = "Şifre Hatası!";
        public static string UserNotFound = "Kullanıcı Bulunamadı!";
    }
}