using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThisneyTicket.Application.Interfaces;
using ThisneyTicket.Application.ViewModel;
using ThisneyTicket.Domain.Interface;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Application.Services
{
    public class EventService : IEventService
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _eventRepository;
        public EventService(IMapper mapper, IEventRepository eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<EventViewModel> Create(EventViewModel eventView)
        {
            return _mapper.Map<EventViewModel>(await _eventRepository.AddAsync(_mapper.Map<Event>(eventView)));
        }

        public async void Delete(EventViewModel eventView)
        {
            await _eventRepository.DeleteAsync(_mapper.Map<Event>(eventView));
        }

        public async Task<IEnumerable<EventViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<EventViewModel>>(await _eventRepository.ListAllAsync());
        }

        public async Task<EventViewModel> GetById(int id)
        {
            return _mapper.Map<EventViewModel>(await _eventRepository.GetByIdAsync(id));
        }

        public async Task<EventViewModel> Update(EventViewModel eventView)
        {
            await _eventRepository.UpdateAsync(_mapper.Map<Event>(eventView));
            return eventView;
        }
    }
}
