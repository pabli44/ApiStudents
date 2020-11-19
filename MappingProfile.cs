using ApiStudents.Dto;
using ApiStudents.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStudents
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();
        }
    }
}
