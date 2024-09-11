using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trainee> trainees = new List<Trainee>();
            trainees.Add(new Trainee {TraineeId=1,TraineeName="Lema",DOB = new DateTime(1998, 10, 25), ContactNo = "12207756" });
            trainees.Add(new Trainee {TraineeId=2,TraineeName="Anwor",DOB = new DateTime(1997, 11, 25), ContactNo = "5852777" });
            trainees.Add(new Trainee {TraineeId=3,TraineeName="Jobida",DOB = new DateTime(1996, 12, 25), ContactNo = "24562275" });
            trainees.Add(new Trainee {TraineeId=4,TraineeName="Ekrom",DOB = new DateTime(1995, 10, 25), ContactNo = "1233246" });
            var anonymousData = from tr in trainees
                                where tr.TraineeId != 3
                                select tr;
            foreach (var t in anonymousData)
            {
                Console.WriteLine("Trainee: " + t.TraineeId + ", " + t.TraineeName);
            }
        }
    }
}
