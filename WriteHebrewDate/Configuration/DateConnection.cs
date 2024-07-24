using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteHebrewDate.Configuration
{
    internal class DateConnection
    {
        public static readonly string _path = Path.Combine(
            Directory.GetCurrentDirectory(), "add-hebrew-date.xml");
    }
}
