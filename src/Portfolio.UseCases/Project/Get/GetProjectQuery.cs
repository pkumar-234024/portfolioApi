using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Get;
public record GetProjectQuery(int Id) : IQuery<Result<Projects>>;
