using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Dtos;
using WEBAPI.Interface;
using WEBAPI.Model;

namespace WEBAPI.Controllers
{
    
    public class CityController : BaseController
    {
       
        private readonly IUnitOfWork uow;
       // private readonly ICityRepository cityrepo;

        public CityController(IUnitOfWork uow)
        {
            //this.cityrepo = cityrepo;
             this.uow = uow;
        }
        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
           // throw new UnauthorizedAccessException();

            var  cities = await uow.CityRepository.GetCitiesAsync();

          //  var citiesdto = new List<CityDto>();
         //   foreach(var ele in cities)
         //   {

                
           // }
             //var citiesdto = from c in cities
             //               select new CityDto()
             //               {
             //                   Id = c.Id,
             //                   Name = c.Name,
             //                   Country =c.Country
                                
             //               };
            return Ok( cities);
        }
        ////api/city/add?cityname=Miami
        ////api/city/add/texas
        ////[HttpPost("add")]
        ////[HttpPost("add/{cityname}")]
        ////public async Task<IActionResult> AddCity(string cityname)
        ////{
        ////    City city = new City();
        ////    city.Name = cityname;
        ////   await dc.Cities.AddAsync(city);
        ////   await dc.SaveChangesAsync();
        ////    return Ok(city);

        ////}

        //[HttpPost("post")]
        //public async Task<IActionResult> AddCity(CityDto citydto)
        //{
        //    City city = new City()
        //    {
        //        Name = citydto.Name,
        //        Country=citydto.Country,
        //        LastUpdatedOn = DateTime.Now,
        //        LastUpdatedBy = 1


        //    };
        //    uow.CityRepository.AddCity(city); ;
        //    await uow.SaveAsync() ;
        //    return StatusCode(201);
        //}

        //[HttpPut("update/{id}")]                                
        //public async Task<IActionResult> UpdateCity(int id,CityUpdateDto citydto)
        //{
        //    //if we pass CityDto then check for country can not be null .it marked as required
        //    var cityGet = await uow.CityRepository.FindCity(id);
        //    if (cityGet == null)
        //       return BadRequest("Update not allowed");
            
        //    cityGet.Name = citydto.Name;
        //   // cityGet.Country = citydto.Country;
        //    cityGet.LastUpdatedOn = DateTime.Now;
        //    cityGet.LastUpdatedBy = 1;

        //    //City city = new City()
        //    //{
        //    //    Name = citydto.Name,
        //    //    Country = citydto.Country,
        //    //    LastUpdatedBy = 1,
        //    //    LastUpdatedOn = DateTime.Now

        //    //    }
        //    // uow.CityRepository.AddCity(city); ;
        //   //throw new Exception("some unknown error");
        //    await uow.SaveAsync();
        //    return StatusCode(200);
        //}

        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteCity(int id)
        //{
        //    uow.CityRepository.DeleteCity(id);
        //    await uow.SaveAsync();
        //    return Ok(id);
        //}

        ////[HttpGet("{id}")]
        ////public City GetCity(int id)
        ////{
        ////    var city = dc.Cities.FirstOrDefault(a=>a.Id==id);
        ////    return (city);
            
        ////}
    }
}
