using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisneyTicket.API.Controllers;
using ThisneyTicket.Application.Interfaces;
using ThisneyTicket.Application.ViewModel;
using ThisneyTicket.UnitTest.Mocks.Api;
using Xunit;

namespace ThisneyTicket.UnitTest.Controller
{
    public class EventControllerTest
    {
        private readonly Mock<IEventService> _apisServiceMock;

        public EventControllerTest()
        {
            _apisServiceMock = new Mock<IEventService>();
        }

        [Fact]
        public async Task GetAll_ReturnAlltheEventsSaved()
        {
            var apisMock = EventApiMocks.ApiResponseModelList;

            _apisServiceMock.Setup(x => x.GetAll())
                .ReturnsAsync(apisMock);

            var apisController = new EventController(_apisServiceMock.Object);
            var apisMethod = await apisController.Get();

            var actionResult = Assert.IsType<OkObjectResult>(apisMethod.Result);
            var actionValue = Assert.IsAssignableFrom<IEnumerable<EventViewModel>>(actionResult.Value);

            Assert.NotEmpty(actionValue);
            Assert.True(actionValue.ToList().Count> 0);
        }
    }
}
