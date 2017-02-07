using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Organizer.DAL;
using Organizer.Service;

namespace Organizer.Api.App_Start
{
    public static class AutoMapperConfig
    {
        //public class Source<T>
        //{
        //    public T Value { get; set; }
        //}

        //public class Destination<T>
        //{
        //    public T Value { get; set; }
        //}
        
        public static void RegisterMapping()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<task_table, TaskDTO>();
                cfg.CreateMap<TaskDTO, task_table>();
                cfg.CreateMap<UserDTO, AspNetUser>();
                cfg.CreateMap<AspNetUser, UserDTO>();

            });

         }


        
    }
}