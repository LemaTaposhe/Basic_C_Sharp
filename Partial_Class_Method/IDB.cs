using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class_Method
{
    public partial class Trainee
    {
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public Trainee()
        {
            GenerateTraineeId();
        }
        partial void GenerateTraineeId();
    }
}
