using System;
using System.Collections.Generic;
using System.Text;
using Test.Helpers;

namespace Test.Model
{
    class Venue
    {
        public static string GenerateURL(double latidude, double longtitude)
        {
            return string.Format(Constants.VENUE_SEARCH, latidude, longtitude, Constants.CLIENT_ID, Constants.CLIENT_SECRET, DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
