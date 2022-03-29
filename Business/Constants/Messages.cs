using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string CategoryAdded = "Kategori başarıyla eklendi.";
        public static string CategoryDeleted = "Kategori başarıyla silindi.";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi.";
        
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı! Yeniden deneyiniz...";
        public static string SuccessfullyLogin = "Giriş işlemleri başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";

        public static string NotEmpty = "Bu alan boş bırakılamaz.";
        public static string CharacterSpacing = "En az 2 ve en fazla 30 karakterden oluşmak zorundadır.";
        public static string AuthorizationDenied = "Yetkiniz yok!";
    }
}
