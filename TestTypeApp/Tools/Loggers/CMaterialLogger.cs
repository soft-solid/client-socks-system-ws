using TestTypeApp.Model;

namespace TestTypeApp.Tools.Loggers
{
    class CMaterialLogger
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(CMaterial));
        private static CMaterialLogger _instance = null;
        private static readonly object padlock = new object();

        public static CMaterialLogger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance != null) return _instance;

                    _log = log4net.LogManager.GetLogger(typeof(CMaterial));
                    _instance = new CMaterialLogger();

                    return _instance;
                }
            }
        }

        public void Info()
        {

        }

        public void Error(CMaterial obj)
        {
            _log.Error(string.Format("There is no subscribers!/n MaterialID:{0}/n MaterialName:{1}", obj.Id, obj.Name));
        }

        public void Debug()
        {

        }
    }
}
