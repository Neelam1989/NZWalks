using NZWalksAPI.Model.Domain;

namespace NZWalksAPI.Repositry
{
    public interface IRegionRepoistry
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
