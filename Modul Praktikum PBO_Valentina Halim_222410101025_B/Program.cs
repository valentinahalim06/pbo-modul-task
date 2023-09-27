using System;
using AMDProcessor = Processor_1025.AMD; // Alias untuk namespace Processor_1025.AMD
using AMDVga = Vga_1025.AMD; // Alias untuk namespace VGA_1025.AMD

namespace Processor_1025
{
    public class Processor
    {
        public string merk;
        public string tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }
    public class Ryzen : AMDProcessor
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    public class Athlon : AMDProcessor
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
}

namespace Vga_1025
{
    public class Vga
    {
        public string merk;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    public class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
}

namespace Laptop_1025
{
    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga_1025.Vga vga;
        public Processor_1025.Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    public class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    public class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    public class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang bermain game");
        }
    }
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "Ideapad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
}

namespace PBO_1025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Laptop_1025.Laptop laptop1 = new Laptop_1025.Vivobook();
            laptop1.vga = new Vga_1025.Nvidia();
            laptop1.processor = new Processor_1025.CoreI5();

            //Console.WriteLine("Spesifikasi laptop1 (Vivobook):"); // no. 3
            //Console.WriteLine($"Merk VGA: {laptop1.vga.merk}");
            //Console.WriteLine($"Merk Processor: {laptop1.processor.merk}");
            //Console.WriteLine($"Tipe Processor: {laptop1.processor.tipe}");

            Laptop_1025.Laptop laptop2 = new Laptop_1025.IdeaPad();
            laptop2.vga = new AMDVga();
            laptop2.processor = new Processor_1025.Ryzen();

            Laptop_1025.Predator predator = new Laptop_1025.Predator();
            predator.vga = new AMDVga();
            predator.processor = new Processor_1025.CoreI7();

            //laptop1.Ngoding(); // no. 2

            laptop2.LaptopDinyalakan(); // no. 1
            laptop2.LaptopDimatikan();

            /* predator.BermainGame();*/ // no. 4

            //Laptop_1025.ACER acer = new Laptop_1025.Predator();
            //acer.BermainGame(); // no. 5

        }
    }
}