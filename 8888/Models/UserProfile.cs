using AutoMapper;

namespace _8888.Models
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
