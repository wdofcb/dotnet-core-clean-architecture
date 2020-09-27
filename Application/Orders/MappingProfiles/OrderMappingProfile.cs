using Application.Orders.Commands;
using Application.Orders.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.Orders.MappingProfiles
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderViewModel, Order>();

            CreateMap<CreateOrderCommand, Order>();
            CreateMap<Order, CreateOrderCommand>();
        }
    }
}
