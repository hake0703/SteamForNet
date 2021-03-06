﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SteamForNet
{
    public abstract class SteamSiteUrl
    {
        /// <summary>
        /// Gets the root URL for the steam store's website.
        /// </summary>
        public static string RootUrl
        {
            get
            {
                return "http://store.steampowered.com/";
            }
        }

        /// <summary>
        /// Returns the URL string containing the entire steam game library.
        /// </summary>
        public static string AllProgramsUrl
        {
            get
            {
                return RootUrl + "search/";
            }
        }

        public static string applicationURL
        {
            get
            {
                return RootUrl + "app/";
            }
        }


    }
}
