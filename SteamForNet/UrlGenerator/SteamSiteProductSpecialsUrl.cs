using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SteamForNet
{
    public class SteamSiteProductSpecialsUrl:SteamSiteUrl
    {
        //Contains the base url for the specials area of the site.
        private string _gameSpecials
        {
            get
            {
                return $"{AllProgramsUrl}?specials=1"; //Needs a number appened to the end of it that corresponds to the page number for the site.
            }
        }

        /// <summary>
        /// Gets the URL for games that are currently on special on steam by page number. :)
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public string getGamesOnSpecial(int pageNumber = 1)
        {
            if (pageNumber == 1)
                return _gameSpecials;
            else
                return $"{_gameSpecials}{SteamSiteFormattingUrl.Additional}page{pageNumber.ToString()}";
        }
    }
}
