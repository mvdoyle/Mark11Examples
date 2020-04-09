using System;
namespace ExamplesForClass
{
    public class TV
    {
        public TV()
        {
        }

        //properties are class members
        public int ScreenSize { get; set; }
        public bool IsFlatScreen { get; set; }
        public bool Is4k { get; set; }
        public string Brand { get; set; }
        public bool IsSmart { get; set; }

        //methods are class members
        public void PrintInfo()
        {
            Console.WriteLine($"Brand name: {Brand}, Screen size:{ScreenSize}");
        }
    }
}
