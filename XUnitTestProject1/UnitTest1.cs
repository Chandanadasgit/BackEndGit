using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEBAPI.Controllers;
using WEBAPI.Interface;
using WEBAPI.Model;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private List<City> GetCityFake()
        {
            var citylist = new List<City>();


            citylist.Add(new City()
            {
                Id = 1,
                Name = "test one",
                Country = "test India"
                //LastUpdatedBy = 1,
                //LastUpdatedOn = DateTime.Now
            });
            citylist.Add(new City()
            {
                Id = 2,
                Name = "test two",
                Country = "test USA",

            });

            return citylist;
        }

        [Fact]
        public async Task GetCities_ReturnsAViewResult_WithAListOfCities ()
        {
            //Arrange
            var mockRepo = new Mock<IUnitOfWork>();
          
            mockRepo.Setup(repo => repo.CityRepository.GetCitiesAsync()).ReturnsAsync(GetCityFake());
            var controller = new CityController(mockRepo.Object);

            //Act
            var okResult = await controller.GetCities() as OkObjectResult;

            //Assert
              var viewResult =   Assert.IsType<List<City>>(okResult.Value);
             //var model = viewResult as IList<City>;
            // var model = Assert.IsAssignableFrom<IList<City>>(
            // viewResult.ViewData.Model); 

            Assert.NotEmpty(viewResult);
           Assert.Equal(2, viewResult.Count);
            Assert.Equal("test two", viewResult[1].Name);

        }

     
    }
}
