using AutoMapper;
using InternSystem.Application.Features.User.Commands;
using InternSystem.Application.Features.User.Models;
using InternSystem.Application.Features.User.Queries;
using InternSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternSystem.Application.Common.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<AspNetUser, GetUserDetailResponse>();
            CreateMap<AspNetUser, CreateUserCommand>().ReverseMap();
            CreateMap<AspNetUser, GetAllUserResponse>();
        }
    }
}
