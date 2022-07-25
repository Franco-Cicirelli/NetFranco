using AutoMapper;
using NetFranco.Dtos;
using NetFranco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFranco.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<Rental, NewRentalDto>();


            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<MembershipTypeDto, MembershipType>();
            Mapper.CreateMap<GenreDto, Genre>();
            Mapper.CreateMap<NewRentalDto, Rental>();
        }
    }
}