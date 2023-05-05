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
        internal static string CarDeleted = "Araç silindi";
        internal static string CarUpdated = "Araç bilgileri güncellendi";
        public static string CarNameInvalid = "Araç isimi iki karakterden uzun olmalı";
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string RentDateInvalid = "Araç henüz teslim edilmemiş";
        internal static string RentalAdded = "Araç Kiralandı";
        internal static string RentalDeleted = "Araç Kiralama iptal edildi";
        internal static string RentalUpdated = "Araç kiralama bilgileri güncellendi";
        internal static string CustomerAdded = "Müşteri eklendi";
        internal static string CustomerDeleted = "Müşteri silindi";
        internal static string CustomerUpdated = "Müşteri bilgileri güncellendi";
        internal static string UserAdded = "Kullanıcı eklendi";
        internal static string UserDeleted = "Kullanıcı silindi";
        internal static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        internal static string ColorAdded = "Renk eklendi";
        internal static string ColorDeleted = "Renk silindi";
        internal static string ColorUpdated = "Renk bilgisi güncellendi";
        internal static string BrandAdded = "Marka eklendi";
        internal static string BrandDeleted = "Marka silindi";
        internal static string BrandUpdated = "Marka bilgisi güncellendi";
        internal static string CarDailyPriceInvalid = "Kiralama bedeli 0 dan büyük olmalı";
    }
}
