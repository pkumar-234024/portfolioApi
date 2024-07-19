using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;
using Humanizer;
using Microsoft.Extensions.Logging;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;
using Portfolio.Infrastructure.Email;

namespace Portfolio.Infrastructure.Errors;
public class ErrorMessageLogger : IErrorLogger
{
  private readonly IRepository<ErrorLogs> _errorLogs;
  private readonly ILogger<SmtpEmailSender> _logger;
  public ErrorMessageLogger(IRepository<ErrorLogs> errorLogs, ILogger<SmtpEmailSender> logger)
  {
    _errorLogs = errorLogs;
    _logger = logger;
  }
  public async Task SaveErrotrLogAsync(string? message, string? innerMessage, string? stackTrace, int? userId, string? contollerName)
  {
    try
    {
      var newError = new ErrorLogs { ContollerName=contollerName, CreatedDate=new DateTime()};
      await _errorLogs.AddAsync(newError);
    }
    catch (Exception ex)
    {     
      _logger.LogWarning($"error occured while attmpting to save the error log {ex.Message}");
    }
  }
}
