using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IST.Api.Helpers.App
{

    public interface ILoggerx
    {
        void Error(string message);

        void Error(Exception ex, string message);

        void Info(string message);

        void Warn(string message);
    }

    public class NLogApp<T> : ILoggerx
    {
        private readonly static ILogger logger;

        static NLogApp()
        {
            NLogApp<T>.logger = LogManager.GetLogger(typeof(T).FullName);
        }

        public NLogApp()
        {
        }

        public void Error(string message)
        {
            NLogApp<T>.logger.Info(message);
        }

        public void Error(Exception ex, string message)
        {
            NLogApp<T>.logger.Error(ex, message);
        }

        public void Info(string message)
        {
            NLogApp<T>.logger.Info(message);
        }

        public void Warn(string message)
        {
            NLogApp<T>.logger.Warn(message);
        }
    }
}