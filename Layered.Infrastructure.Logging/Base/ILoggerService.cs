namespace Layered.Infrastructure.Logging.Base;

public interface ILoggerService
{
    void LogError(string errorMessage);

    void LogError(string errorMessage, params object[] args);

    void LogException(Exception ex);

    void LogInfo(string infoMessage);

    void LogInfo(string infoMessage, params object[] args);
}