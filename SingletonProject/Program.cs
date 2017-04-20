using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonProject
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Emperor.Instance.Value);
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
