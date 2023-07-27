using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace CariKartlar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CariAcilisKarti(
                new DistrictManager(new EfDistrictDal()),
                new CountryManager(new EfCountryDal()),
                new CityManager(new EfCityDal()),
                new CurrentCodeManager(new EfCurrentCodeDal()),
                new CurrentGroupCodeManager(new EfCurrentGroupCodeDal()),
                new CurrentManager(new EfCurrentDal()),
                new DebtManager(new EfDebtDal())
                ));
        }
    }
}