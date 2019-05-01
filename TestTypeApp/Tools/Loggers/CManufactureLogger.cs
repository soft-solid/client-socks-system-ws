using TestTypeApp.Model;

namespace TestTypeApp.Tools.Loggers
{
    class CManufactureLogger
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(CManufacture));
        private static CManufactureLogger _instance = null;
        private static readonly object padlock = new object();

        public static CManufactureLogger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance != null) return _instance;

                    _log = log4net.LogManager.GetLogger(typeof(CManufacture));
                    _instance = new CManufactureLogger();

                    return _instance;
                }
            }
        }

        public void Info()
        {

        }

        public void Error(CManufacture obj)
        {
            _log.Error(string.Format("There is no subscribers!/n ManufactureID:{0}/n ManufactureName:{1}", obj.Id, obj.Name));
        }

        public void Debug()
        {

        }
    }
}
