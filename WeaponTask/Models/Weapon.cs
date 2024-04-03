using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponTask.Models
{
    using System;

    class Weapon
    {
        private string _shootMode;
        private int _bulletCount;
        private int _reloadTimeSeconds;

        public Weapon(string shootMode, int bulletCount, int reloadTimeSeconds)
        {
            _shootMode = shootMode;
            _bulletCount = bulletCount;
            _reloadTimeSeconds = reloadTimeSeconds;
        }

        public void Shoot()
        {
            Console.WriteLine("1 gülle atıldı.");
            _bulletCount--;
        }

        public void Fire()
        {
            Console.WriteLine($"Daraq boşaldı. Bitme vaxdı: {_reloadTimeSeconds} saniye.");
            _bulletCount = 0;
        }

        public int GetRemainBulletCount()
        {
            return _bulletCount;
        }

        public void Reload()
        {
            _bulletCount = GetRemainBulletCount();
            Console.WriteLine("Daraq yenidən dolduruldu.");
        }

        public void ChangeFireMode()
        {
            if (_shootMode == "tekli")
            {
                _shootMode = "avtomatik";
            }
            else if (_shootMode == "avtomatik")
            {
                _shootMode = "tekli";
            }
            Console.WriteLine($"Atış modu deyişdirildi. Yeni mod: {_shootMode}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Atış modu: {_shootMode}");
            Console.WriteLine($"Gülle sayı: {_bulletCount}");
            Console.WriteLine($"Sıfırlama saniyesi: {_reloadTimeSeconds}");
        }
    }

}
