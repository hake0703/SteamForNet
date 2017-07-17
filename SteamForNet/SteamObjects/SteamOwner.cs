using System;
using System.Collections.Generic;
using System.Text;

namespace SteamForNet
{
    class SteamOwner
    {
        public SteamOwner(string steamAPIKey)
        {
            this.SteamAPIKey = steamAPIKey;
        }

        public string SteamAPIKey
        {
            get { return SteamAPIKey; }
            set { SteamAPIKey = value; }
        }
    }
}
