using System;
using System.Collections.Generic;
using System.Text;

namespace SteamForNet
{
    public abstract class SteamApplication
    {
        /// <summary>
        /// The steam application ID.
        /// </summary>
        protected int appId
        {
            get { return appId; }
            set { appId = value; }
        }

        /// <summary>
        /// The title of the application.
        /// </summary>
        protected string name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Current Steam price of the application.
        /// </summary>
        protected decimal price
        {
            get { return price; }
            set { price = value; }
        }
        
        /// <summary>
        /// Current steam rating of the application.
        /// </summary>
        protected string rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
