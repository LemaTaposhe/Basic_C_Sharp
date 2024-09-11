using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class_Method
{
    public partial class Trainee
    {
        public Trainee(int id, string name)
        { 
        this.TraineeId = id;
            this.TraineeName = name;
        }
        public void TraineeInfo()
        {
            Console.WriteLine(this.TraineeId+" "+this.TraineeName);
        }
        partial void GenerateTraineeId()
        { 
        Random random = new Random();
            this.TraineeId = random.Next();
        }
    }
}
