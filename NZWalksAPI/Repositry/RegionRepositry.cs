using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Data;
using NZWalksAPI.Model.Domain;

namespace NZWalksAPI.Repositry
{
    public class RegionRepositry : IRegionRepoistry
    {
        NZWalkDBContext _nZWalkDBContext;
        public RegionRepositry(NZWalkDBContext nZWalkDBContext)
        {
            _nZWalkDBContext = nZWalkDBContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await _nZWalkDBContext.Region.ToListAsync();
        }
    }
}
