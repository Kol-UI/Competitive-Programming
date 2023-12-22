using System;
namespace CompetitiveProgramming.Models
{
    public class TableData
    {
        public required string Source { get; set; }
        public int? Other { get; set; }
        public int? Easy { get; set; }
        public int? Medium { get; set; }
        public int? Hard { get; set; }

        public int GetTotal()
        {
            int easyValue = Easy ?? 0;
            int mediumValue = Medium ?? 0;
            int hardValue = Hard ?? 0;

            return (Other ?? 0) + easyValue + mediumValue + hardValue;
        }
    }
}