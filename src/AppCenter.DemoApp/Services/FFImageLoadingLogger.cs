﻿using System;
using FFImageLoading.Helpers;
using Prism.Logging;
using System.Collections.Generic;
namespace AppCenter.DemoApp.Services
{
    public class FFImageLoadingLogger : IMiniLogger
    {
        private ILogger _logger { get; }

        public FFImageLoadingLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string errorMessage)
        {
            _logger.Warn(errorMessage);
        }

        public void Error(string errorMessage, Exception ex)
        {
            _logger.Report(ex, new Dictionary<string, string>{
                { "message", errorMessage }
            });
        }
    }
}
