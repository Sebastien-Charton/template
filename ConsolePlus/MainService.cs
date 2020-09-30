using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// DI, Serilog, Settings

namespace ConsolePlus
{
    public class MainService : IMainService
    {
        private readonly ILogger<MainService> _log;
        private readonly IConfiguration _config;

        public MainService(ILogger<MainService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }

        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _log.LogError("Run number {runNumber}", i);
            }
        }
    }
}
