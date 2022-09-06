using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    class SmartPhone
    {
        private string Galary { get; set; }
       
        private int serialNoId { get; set; }

        private string NotificationFromApps { get; set; }

        private int IncomingCalls { get; set; }

        private string DeviceName { get; set; }

        private int SoftwareVersion { get; set; }

        private int BattryLife { get; set; }

        private string SimSlot { get; set; }

        private int ModelNumber { get; set; }

        private int WiFiAddress { get; set; }

        private int ImeiNo { get; set; }

        private string Settings { get; set; }

        private string Screen { get; set; }
    }
    class SmartWatch : SmartPhone
    {
        
    }
    class SmartTv : SmartPhone
    {
        int ScreenType(int inches, int fameSize)
        {
            return 32;
        }

    }
    class Laptop : SmartPhone
    {
        

    }


        

}
