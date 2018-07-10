//using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Syslog.Framework.Logging
{
	public static class SyslogLoggerFactoryExtensions
	{
		public static void AddSyslog(this ILoggerFactory loggerFactory, SyslogLoggerSettings settings, string hostName = null, LogLevel logLevel = LogLevel.Debug)
		{
			loggerFactory.AddProvider(new SyslogLoggerProvider(settings, hostName ?? System.Environment.MachineName, logLevel));
		}

		public static void AddSyslog(this ILoggingBuilder logbldr, SyslogLoggerSettings settings, string hostName = null, LogLevel logLevel = LogLevel.Debug)
		{
			logbldr.AddProvider(new SyslogLoggerProvider(settings, hostName ?? System.Environment.MachineName, logLevel));
		}

	}
}
