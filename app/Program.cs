// See https://aka.ms/new-console-template for more information
using app.Entities.Abstract;
using app.Entities.Concrete;
using app.Business;
using app.Business.Concrete;
using app.Core.Logging;

class Program
{
    static void Main(string[] args)
    {
        IVehicle car = new Car();
        IVehicle otobus = new Otobus();
        IVehicle minibus = new Minibus();
        IBoothService booth = new BoothManager();
        List<IVehicle> cars = new List<IVehicle>();
        Logger log = new Logger();

        car.HgsNo = "1235";
        car.OwnerName = "Esma";
        car.OwnerSurname = "Karagulle";
        car.VehicleType = "Car";
        car.Date = new DateTime(2022, 9, 8);
        car.Balance = 100;
        cars.Add(car);

        minibus.HgsNo = "1234";
        minibus.OwnerName = "Nisa";
        minibus.OwnerSurname = "Karagulle";
        minibus.VehicleType = "Minibus";
        minibus.Date = new DateTime(2022, 9, 8);
        minibus.Balance = 150;
        cars.Add(minibus);

        otobus.HgsNo = "1234";
        otobus.OwnerName = "Merve";
        otobus.OwnerSurname = "Karagulle";
        otobus.VehicleType = "Otobus";
        otobus.Date = new DateTime(2022, 7, 9);
        otobus.Balance = 120;
        cars.Add(otobus);




        while (true)
        {
            Console.WriteLine("Gecis yapacak arac tipini seciniz:");
            Console.WriteLine("1-Araba  \n2-Minibus \n3-Otobus \n4-Gunluk Kazanci Yazdir");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Arac sahibi: " + car.OwnerName + " " + car.OwnerSurname);
                    Console.WriteLine("HGS No: " + car.HgsNo);
                    Console.WriteLine("Gecis Tarihi: " + car.Date);
                    Console.WriteLine("Mevcut bakiye: " + car.Balance);
                    Console.WriteLine("Sectiginiz arac icin gecis bedeli: " + car.Still);
                    double resultCar = booth.Payment(car);
                    Console.WriteLine("Gecis sonrasi kalan bakiye: " + resultCar);

                    break;
                case 2:
                    Console.WriteLine("Arac sahibi: " + minibus.OwnerName + " " + minibus.OwnerSurname);
                    Console.WriteLine("HGS No: " + minibus.HgsNo);
                    Console.WriteLine("Gecis Tarihi: " + minibus.Date);
                    Console.WriteLine("Mevcut bakiye: " + minibus.Balance);
                    Console.WriteLine("Sectiginiz arac icin gecis bedeli: " + minibus.Still);
                    double resultMinibus = booth.Payment(minibus);
                    Console.WriteLine("Gecis sonrasi kalan bakiye: " + resultMinibus);
                    break;
                case 3:
                    Console.WriteLine("Arac sahibi: " + otobus.OwnerName + " " + otobus.OwnerSurname);
                    Console.WriteLine("HGS No: " + otobus.HgsNo);
                    Console.WriteLine("Gecis Tarihi: " + otobus.Date);
                    Console.WriteLine("Mevcut bakiye: " + otobus.Balance);
                    Console.WriteLine("Sectiginiz arac icin gecis bedeli: " + otobus.Still);
                    double resultOtobus = booth.Payment(otobus);
                    Console.WriteLine("Gecis sonrasi kalan bakiye: " + resultOtobus);
                    break;
                case 4:
                    int total = booth.DailyPass(cars);
                    double totals = Logger.Report(cars);
                    Console.WriteLine("Bugun gecen toplam arac : {0}", total);
                    Console.WriteLine("Bugun elde edilen toplam kazanc : {0}", totals);
                    break;
            }
        }

    }
}


