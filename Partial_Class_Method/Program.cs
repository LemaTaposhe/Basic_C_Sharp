using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class_Method
{
    //public  class Trainee
    //{
    //    public int TraineeId { get; set; }
    //    public string TraineeName { get; set; }
    //    public Trainee()
    //    {
    //        GenerateTraineeId();
    //    }
    //     void GenerateTraineeId();
    //}

    //public  class Trainee
    //{
    //    public Trainee(int id, string name)
    //    {
    //        this.TraineeId = id;
    //        this.TraineeName = name;
    //    }
    //    public void TraineeInfo()
    //    {
    //        Console.WriteLine(this.TraineeId + " " + this.TraineeName);
    //    }
    //    partial void GenerateTraineeId()
    //    {
    //        Random random = new Random();
    //        this.TraineeId = random.Next();
    //    }
    //}

    internal class Program
    {
      
        static void Main(string[] args)
        {
            var trn = new Trainee();
            Console.WriteLine( trn.TraineeId);
            Console.ReadLine();

        }
    }
}
