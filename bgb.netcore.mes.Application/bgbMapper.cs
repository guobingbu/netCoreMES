using AutoMapper;
using bgb.netcore.mes.Application.DepartmentApp.Dtos;
using bgb.netcore.mes.Application.MenuApp.Dtos;
using bgb.netcore.mes.Application.RoleApp.Dtos;
using bgb.netcore.mes.Application.UserApp.Dtos;
using bgb.netcore.mes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bgb.netcore.mes.Application
{
    /// <summary>
    /// Enity与Dto映射
    /// </summary>
    public class bgbMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Menu, MenuDto>();
                cfg.CreateMap<MenuDto, Menu>();
                cfg.CreateMap<Department, DepartmentDto>();
                cfg.CreateMap<DepartmentDto, Department>();
                cfg.CreateMap<RoleDto, Role>();
                cfg.CreateMap<Role, RoleDto>();
                cfg.CreateMap<RoleMenuDto, RoleMenu>();
                cfg.CreateMap<RoleMenu, RoleMenuDto>();
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserRoleDto, UserRole>();
                cfg.CreateMap<UserRole, UserRoleDto>();
            });
        }
    }
}
