using System;

namespace ExamplesForClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var michaelsTV = new TV();

            michaelsTV.Is4k = true;
            michaelsTV.Brand = "Samsung";
            michaelsTV.IsFlatScreen = true;
            michaelsTV.ScreenSize = 55;

            var brettsTV = new TV();
            brettsTV.Is4k = false;
            brettsTV.IsFlatScreen = false;
            brettsTV.ScreenSize = 19;
            brettsTV.IsSmart = false;
            brettsTV.Brand = "Magnavox";

            brettsTV.PrintInfo();
        }
    }
}
