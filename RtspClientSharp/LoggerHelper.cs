using Serilog;

namespace RtspClientSharp
{
    internal static class LoggerHelper
    {
        public static readonly ILogger Logger = new LoggerConfiguration().
             MinimumLevel.Verbose()
             .WriteTo.File(
                 "Logs\\Requests.txt",
                 outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} {MachineName} [{Level}] {Message}{NewLine}{Exception}").
             CreateLogger();
    }
}
