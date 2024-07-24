using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WriteHebrewDate.Model;
using static WriteHebrewDate.Configuration.DateConnection;


namespace WriteHebrewDate.Service
{
    internal static class DateService
    {
        public static DateModel ChooseDate(string dayInWeek, string dayInMonth, string month, string year)
        {
            DateModel date = new ();
            date.DayInWeek = dayInWeek;
            date.DayInMonth = dayInMonth;
            date.Month = month;
            date.Year = year;
            return date;
        }

        public static string ConvertToDayInWeek(DateModel date)
        {
            string dayInWeek = date.DayInWeek switch
            {
                "ראשון" => "באחד בשבת",
                "שני" => "בשני בשבת",
                "שלישי" => "בשלישי בשבת",
                "רביעי" => "ברביעי בשבת",
                "חמישי" => "בחמישי בשבת",
                "שישי" => "בשישי בשבת",
                "שבת" => "בשביעי בשבת"
            };
            return dayInWeek;
        }

        public static string ConvertToDayInMonth(DateModel date)
        {
            string dayInMonth = date.DayInMonth switch
            {
                "1" => "יום אחד",
                "2" => "שני ימים",
                "3" => "שלושה ימים",
                "4" => "ארבעה ימים",
                "5" => "חמישה ימים",
                "6" => "שישה ימים",
                "7" => "שבעה ימים",
                "8" => "שמונה ימים",
                "9" => "תשעה ימים",
                "10" => "עשרה ימים",
                "11" => "אחד עשר יום",
                "12" => "שנים עשר יום",
                "13" => "שלושה עשר יום",
                "14" => "ארבעה עשר יום",
                "15" => "חמישה עשר יום",
                "16" => "שישה עשר יום",
                "17" => "שבעה עשר יום",
                "18" => "שמונה עשר יום",
                "19" => "תשעה עשר יום",
                "20" => "עשרים יום",
                "21" => "אחד ועשרים יום",
                "22" => "שנים ועשרים יום",
                "23" => "שלושה ועשרים יום",
                "24" => "ארבעה ועשרים יום",
                "25" => "חמישה ועשרים יום",
                "26" => "שישה ועשרים יום",
                "27" => "שבעה ועשרים יום",
                "28" => "שמונה ועשרים יום",
                "29" => "תשעה ועשרים יום",
                "30" => "יום שלושים"
            };
            return dayInMonth;
        }

        public static string ConvertToMonth(DateModel date)
        {
            string month = date.Month switch
            {
                "תשרי" => "לחודש תשרי",
                "מרחשון" => "לחודש מרחשון",
                "כסלו" => "לחודש כסלו",
                "טבת" => "לחודש טבת",
                "שבט" => "לחודש שבט",
                "אדר" => "לחודש אדר",
                "אדר הראשון" => "לחודש אדר  הראשון",
                "אדר השני" => "לחודש אדר השני",
                "ניסן" => "לחודש ניסן",
                "אייר" => "לחודש אייר",
                "סיון" => "לחודש סיון",
                "תמוז" => "לחודש תמוז",
                "אב" => "לחודש אב",
                "אלול" => "לחודש אלול"
            };
            return month;
        }

        public static string ConvertToYear(DateModel date)
        {
            string year = date.Year switch
            {
                "תשפ'ד" => "שנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם",
                "תשפ'ה" => "שנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם",
                "תשפ'ו" => "שנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם",
                "תשפ'ז" => "שנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם",
                "תשפ'ח" => "שנת חמשת אלפים ושבע מאות ושמנים ושמונה לבריאת העולם",
                "תשפ'ט" => "שנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם",
                "תש'צ" => "שנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם",
                "תשצ'א" => "שנת חמשת אלפים ושבע מאות ותשעים ואחד לבריאת העולם",
                "תשצ'ב" => "שנת חמשת אלפים ושבע מאות ותשעים ושתים לבריאת העולם",
                "תשצ'ג" => "שנת חמשת אלפים ושבע מאות ותשעים ושלוש לבריאת העולם"

            };
            return year;
        }

        public static string AddAllConvertTogether(DateModel date)
        {
            string dayInMonth = ConvertToDayInMonth(date);

            if (dayInMonth == "יום שלושים")
            {
                dayInMonth = date.Month switch
                {
                    "תשרי" => $" לחודש {date.Month} שהוא ראש חודש מרחשון",
                    "חשון" => $" לחודש {date.Month} שהוא ראש חודש כסלו",
                    "כסלו" => $" לחודש {date.Month} שהוא ראש חודש טבת",
                    "טבת" => $" לחודש {date.Month} שהוא ראש חודש שבט",
                    "שבט" => $" לחודש {date.Month} שהוא ראש חודש אדר",
                    "אדר" => $" לחודש {date.Month} שהוא ראש חודש ניסן",
                    "אדר הראשון" => $" לחודש {date.Month} שהוא ראש חודש אדר השני",
                    "אדר השני" => $" לחודש {date.Month} שהוא ראש חודש ניסן",
                    "ניסן" => $" לחודש {date.Month} שהוא ראש חודש אייר",
                    "אייר" => $" לחודש {date.Month} שהוא ראש חודש סיון",
                    "סיון" => $" לחודש {date.Month} שהוא ראש חודש תמוז",
                    "תמוז" => $" לחודש {date.Month} שהוא ראש חודש אב",
                    "אב" => $" לחודש {date.Month} שהוא ראש חודש אלול",
                    "אלול" => $" לחודש {date.Month} שהוא ראש חודש תשרי",
                    _ => string.Empty
                };
                return $"{ConvertToDayInWeek(date)}  {ConvertToDayInMonth(date)}" +
                $" {dayInMonth}  {ConvertToYear(date)}";
            }

            return $"{ConvertToDayInWeek(date)}  {ConvertToDayInMonth(date)}" +
                $" {ConvertToMonth(date)}  {ConvertToYear(date)}";
        }

        public static void AddToDocument(DateModel date)
        {
            if (!File.Exists(_path))
            {
                XDocument document = new();
                XElement queries = new("Queries");
                document.Add(queries);
                document.Save(_path);
            }

            XDocument doc = XDocument.Load(_path);

            XElement day = new("Day", date.DayInWeek);
            XElement dayInMonth = new("DayMonth", date.DayInMonth);
            XElement month = new("Month", date.Month);
            XElement year = new("Year", date.Year);
            XElement result = new("Result", AddAllConvertTogether(date));

            XElement? Queries = doc.Descendants("Queries").FirstOrDefault();
            if (Queries == null)
            {
                return;
            }

            XElement query = new("Query", day, dayInMonth, month, year, result);
            Queries.Add(query);
            doc.Save(_path);
        
            
        }
    }
}
