using WeaponTask.Models;


namespace WeaponTask
{
    class Program
    {
        static void Main()
        {
            Weapon weapon = new Weapon("tekli", 30, 7);

            while (true)
            {
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - Fire metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Proqramdan dayandırmaq üçün");
                Console.WriteLine("qısayoldur");

                Console.Write("Seçiminizi daxil edin: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        weapon.ShowInfo();
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine($"Qalan güle sayı: {weapon.GetRemainBulletCount()}");
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        break;
                    case "6":
                        Console.WriteLine("Proqram dayandırılır...");
                        return;
                    case "qısayoldur":
                        Console.WriteLine("Proqram dayandırılır...");
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }

            }
        }
    }
}