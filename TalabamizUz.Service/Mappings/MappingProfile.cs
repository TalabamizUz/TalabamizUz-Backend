using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Models.Account;

namespace TalabamizUz.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForCreate, User>().ReverseMap();
            CreateMap<User, UserWithoutPassword>().ReverseMap();
            CreateMap<IEnumerable<User>, IEnumerable<UserWithoutPassword>>().ReverseMap();
        }
    }
}
