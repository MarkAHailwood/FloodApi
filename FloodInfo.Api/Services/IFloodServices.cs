using FloodInfo.lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloodInfo.Api.Services
{
    public interface IFloodServices
    {
        Task<string> GetFloodData(string searchCriteria);
    }
}
