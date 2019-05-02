using log4net;
using TestTypeApp.Model;

namespace TestTypeApp.Tools.Loggers
{
    class CTypeLogger
    {
        private static ILog _log = LogManager.GetLogger(typeof(CType));
        private static CTypeLogger _instance = null;
        private static readonly object padlock = new object();

        public static CTypeLogger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance != null) return _instance;

                    _log = LogManager.GetLogger(typeof(CType));
                    _instance = new CTypeLogger();

                    return _instance;
                }
            }
        }

        public void Info(CType obj)
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
