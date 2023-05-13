using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç bilgileri güncellendi";
        public static string CarNameInvalid = "Araç isimi iki karakterden uzun olmalı";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string RentDateInvalid = "Araç henüz teslim edilmemiş";
        public static string RentalAdded = "Araç Kiralandı";
        public static string RentalDeleted = "Araç Kiralama iptal edildi";
        public static string RentalUpdated = "Araç kiralama bilgileri güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk bilgisi güncellendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka bilgisi güncellendi";
        public static string CarDailyPriceInvalid = "Kiralama bedeli 0 dan büyük olmalı";
        public static string CarImageLimitReached = "En fazla 5 fotoğraf eklenebilir";
        public static string CarImageDeleted ="Fotoğraf silindi";
    }
}
