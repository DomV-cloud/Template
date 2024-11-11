﻿namespace Template.Application.Services.Logging
{
    public interface ILoggingService
    {
        Task LogInformationAsync(string message, params object?[] args);
        Task LogWarningAsync(string message, params object?[] args);
        Task LogErrorAsync(string message, params object?[] args);
    }
}
