using AutoMapper;
using DTOLayer.AnnouncementDTOs;
using DTOLayer.AppUserDTOs;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        protected MapProfile()
        {
            CreateMap<AnnouncementAddDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTOs>();

            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();
        }
    }
}
