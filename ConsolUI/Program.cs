using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----------------SEÇİLEN ARAÇ-------------------------");
        BrandManager brandManager = new BrandManager(new InBrandDal());
        foreach (var brand in brandManager.GetById(2))
        {
            Console.WriteLine("Arac İsmi  :  " + brand.BrandName);
        }

        ColorManager colorManager = new ColorManager(new InColorDal());
        foreach (var color in colorManager.GetById(2))
        {
            Console.WriteLine("Arac Rengi  :  " + color.ColorName);
        }

        CarManager carManager = new CarManager(new InMemoryDal());
        foreach (var cars in carManager.GetById(1))
        {
            Console.WriteLine("Detaylar  :  "  + cars.Description);
        }

        Console.WriteLine("****************************************");

        BrandManager brandManagers = new BrandManager(new InBrandDal());
        foreach (var brands in brandManagers.GetAll())
        {
            Console.WriteLine("Arac İsimleri  :  " + "\n" + brands.BrandName);
            Console.WriteLine("---------------------------------------------");
        }


        ColorManager colorManagers = new ColorManager(new InColorDal());
        foreach (var colors in colorManagers.GetAll())
        {
            Console.WriteLine("Arac Renkleri  :  " + "\n" + colors.ColorName);
            Console.WriteLine("---------------------------------------------");
        }

        CarManager carManagers = new CarManager(new InMemoryDal());
        foreach (var carss in carManagers.GetAll())
        {
            Console.WriteLine("Arac Detayları  :  " + "\n" + carss.Description);
            Console.WriteLine("---------------------------------------------");
        }









    }
}