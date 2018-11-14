using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone2
{
    
   public  class Logger
    {
     

        
        //private static object obj = new object();
        private class inner
        {
            public static Logger logger;
            static inner()
            {
                logger = new Logger();
            }

        }
        private Logger()
        {
        }
        public static Logger Instance
        {
            get
            {
                return inner.logger;
            }
        }
        #region Semi-Lazy Loading
        //private static Logger logger;
        //static Logger()
        //{
        //    logger = new Logger();
        //}
        #endregion
        #region with double check
        //public static Logger Instance
        //{
        //    get
        //    {
        //     if(logger == null)
        //      {
        //        lock(obj){
        //            if (logger == null)
        //            {
        //                logger = new Logger();
        //            }
        //        }
        //      }
        //        return logger;
        //     }
        //}
        #endregion
        #region with lock
        //public static Logger Instance
        //{
        //    get
        //    {
        //        lock(obj){
        //            if (logger == null)
        //            {
        //                logger = new Logger();
        //            }
        //        }
        //        return logger;
        //     }
        //}
        #endregion
        #region without lock
        //public static Logger Instance
        //{
        //    get
        //    {
        //     
        //            if (logger == null)
        //            {
        //                logger = new Logger();
        //            }
        //        
        //        return logger;
        //     }
        //}
        #endregion

        public void LogInfo(string msg)
        {
            Console.WriteLine("Info : "+ msg);

        }

        public void LogError(string error)
        {
            Console.WriteLine("Error : " + error);

        }
        
      

    }
}
 