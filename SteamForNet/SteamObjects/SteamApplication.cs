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
        protected int Id
        {
            get { return Id; }
            set { Id = value; }
        }

        /// <summary>
        /// The title of the application.
        /// </summary>
        protected string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        /// <summary>
        /// Current Steam price of the application.
        /// </summary>
        protected decimal Price
        {
            get { return Price; }
            set { Price = value; }
        }
        
        /// <summary>
        /// Current steam rating of the application.
        /// </summary>
        protected string Rating
        {
            get { return Rating; }
            set { Rating = value; }
        }
    }
}
