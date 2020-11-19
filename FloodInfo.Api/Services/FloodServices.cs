using FloodInfo.Api.Flood;
using FloodInfo.lib.Models;
using System.Threading.Tasks;

namespace FloodInfo.Api.Services
{
    public class FloodServices : IFloodServices
    {
        private static IGetFloodData _floodData;
        public FloodServices(IGetFloodData floodData)
        {
            _floodData = floodData;
        }

        public async Task<FloodModel> GetFloodData(string searchCriteria)
        {
            return await _floodData.ReturnFloodData(searchCriteria);
        }
    }
}
