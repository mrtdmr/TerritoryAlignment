using Application.Plans.Dtos;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Plans
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Plan, PlanDto>();
            CreateMap<Team, TeamDto>();
            CreateMap<Deduction, DeductionDto>();
            CreateMap<DeductionDetail, DeductionDetailDto>();
            CreateMap<Induction, InductionDto>();
            CreateMap<InductionDetail, InductionDetailDto>();
            CreateMap<Segment, SegmentDto>();
            CreateMap<Department, DepartmentDto>();
        }
    }
}
