using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string carAdded = "Araba Eklendi.";
        public static string carAddedInvalidName = "Araba İsmi 2 Karakterden Kısa";
        public static string carAllListed = "Arabaların Hepsi Listelendi.";
        public static string carAllListedByFilter = "Arabalar Filtrelendi.";
        public static string rentalAdded = "Kiralama Eklendi.";
        public static string rentalAddedNoReturnDate = "Araba Henüz Geri Verilmemiş, Kiralayamazsınız.";
        public static string AuthorizationDenied = "Yetki Reddedildi.";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static string AccessTokenCreated;
        internal static string UserAlreadyExists;
        internal static string SuccessfulLogin;
        internal static User PasswordError;
    }
}
