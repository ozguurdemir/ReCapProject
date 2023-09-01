using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string CarPriceInvalid = "Araba Fiyatı Geçersiz";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteriler Listelendi";
        public static List<Car> MaintenanceTime;
        public static string CarsListed = "Arabalar Listelendi";
    }
}
