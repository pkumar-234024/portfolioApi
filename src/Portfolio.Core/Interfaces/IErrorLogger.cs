using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Interfaces;
public interface IErrorLogger
{
  Task SaveErrotrLogAsync(string? message, string? innerMessage, string? stackTrace, int? userId, string? contollerName);
}
