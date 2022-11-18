using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Model.Domain;
using NZWalksAPI.Repositry;

namespace NZWalksAPI.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionController : Controller
    {
        private readonly IRegionRepoistry regionRepoistry;
        private readonly IMapper autoMapper;

        public RegionController(IRegionRepoistry regionRepoistry, IMapper autoMapper)
        {
            this.regionRepoistry = regionRepoistry;
            this.autoMapper = autoMapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRegions() 
        {
            var regions = await regionRepoistry.GetAllAsync();

            //// return DTO regions
            //var regionsDTO = new List<Model.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Model.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,
            //    };

            //    regionsDTO.Add(regionDTO);
            //});
            var regionsDTO = autoMapper.Map<List<Model.DTO.Region>>(regions);
            return Ok(regionsDTO);
        }
    }
}
