using System;
using SteamForNet;
using System.Diagnostics;

namespace SteamForNetTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SteamSiteFormattingUrl.filter);

            SteamSiteProductSpecialsUrl url = new SteamSiteProductSpecialsUrl();
            
            Console.WriteLine(url.getGamesOnSpecial(2));
            Console.WriteLine(url.getGamesOnSpecial(2));
            Console.ReadKey();
        }
    }
}