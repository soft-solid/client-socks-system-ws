using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Model;

namespace TestTypeApp.Tools.Loggers
{
    class CTypeLogger
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(CType));
        private static CTypeLogger _instance = null;
        private static readonly object padlock = new object();

        public static CTypeLogger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance != null) return _instance;

                    _log = log4net.LogManager.GetLogger(typeof(CType));
                    _instance = new CTypeLogger();

                    return _instance;
                }
            }
        }

        public void Info()
        {

        }

        public void Error(CType obj)
        {
            _log.Error(string.Format("There is no subscribers!/n TypeID:{0}/n TypeName:{1}", obj.Id, obj.Name));
        }

        public void Debug()
        {

        }
    }
}
