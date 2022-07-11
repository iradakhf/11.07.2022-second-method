using System;
namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice invoice = new Invoice("1542", "Ird", "SuperMarket");
            Invoice articleLapTop = new Invoice(1200);
            articleLapTop.Article = "LapTop";
            articleLapTop.Quantity = 2;
            Invoice articleSdCard = new Invoice(30);
            articleSdCard.Article = "SdCard";
            articleSdCard.Quantity = 2;
            Invoice articleUsb = new Invoice(12);
            articleUsb.Article = "USB";
            articleUsb.Quantity = 4;



            Console.WriteLine($"{articleLapTop.Quantity} {articleLapTop.Article} : {articleLapTop.CostCalculation(true)} AZN ");
        }

    }
}
