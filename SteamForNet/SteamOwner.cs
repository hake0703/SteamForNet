using System;
using System.Collections.Generic;
using System.Text;

namespace SteamForNet
{
    class SteamOwner
    {
        public SteamOwner(string steamAPIKey)
        {
            this.steamAPIKey = steamAPIKey;
        }

        private string _steamAPIKey = null;
        public string steamAPIKey
        {
            get { return _steamAPIKey; }
            set { _steamAPIKey = value; }
        }
    }
}
