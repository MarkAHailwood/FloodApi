using FloodInfo.lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloodInfo.Api.Flood
{
    public interface IGetFloodData
    {
        Task<string> ReturnFloodData(string searchCritera);
    }
}
