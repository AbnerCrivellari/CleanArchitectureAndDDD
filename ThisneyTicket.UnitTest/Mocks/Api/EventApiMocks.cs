using AutoBogus;
using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Application.ViewModel;

namespace ThisneyTicket.UnitTest.Mocks.Api
{
    public class EventApiMocks
    {
        public static IEnumerable<EventViewModel> ApiResponseModelList =>
                AutoFaker.Generate<EventViewModel>(10);

        public static EventViewModel ApiResponseModel =>
            new AutoFaker<EventViewModel>()
            .RuleFor(p => p.Name, f => f.Company.CompanyName())
            .RuleFor(p => p.Description, f => f.Company.CompanyName())
            .RuleFor(p => p.Date, DateTime.Now)
            .RuleFor(p => p.Quantity, f => f.Random.Int(1, 100))
            .Generate();
    }
}
