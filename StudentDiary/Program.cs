using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(1);
            diary.AddRating(3);

            float Avg = diary.CalculateAverage();
            float Max = diary.GiveMaxRating();
            float Min = diary.GiveMinRating();

        }
    }
}
