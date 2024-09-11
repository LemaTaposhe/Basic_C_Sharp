using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_01
{
    interface IParentInterface
    {
        void ParentInterfaceMethod01();
        void ParentInterfaceMethod02();
    }
    interface IMyInterface
    {
        void ParentInterfaceMethod03();
    }
    interface IIdbInterface : IParentInterface, IMyInterface
    {
        void ParentInterfaceMethod04();
    }
    internal class Program:IIdbInterface
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test-------");
            Program p = new Program();
            p.ParentInterfaceMethod01();
        }

        private void ParentInterfaceMethod01()
        {
            throw new NotImplementedException();
        }

        void IParentInterface.ParentInterfaceMethod01()
        {
            throw new NotImplementedException();
        }

        void IParentInterface.ParentInterfaceMethod02()
        {
            throw new NotImplementedException();
        }

        void IMyInterface.ParentInterfaceMethod03()
        {
            throw new NotImplementedException();
        }

        void IIdbInterface.ParentInterfaceMethod04()
        {
            throw new NotImplementedException();
        }
    }
}
