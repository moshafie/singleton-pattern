using Singletone2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.LogInfo("frist Instans");
            Logger logger2 = Logger.Instance;
            logger2.LogError("second instanc");
            Console.WriteLine(object.ReferenceEquals(logger, logger2));
            Console.ReadLine();
        }
    }
}
