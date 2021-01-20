﻿using Application.Campuses.Queries;
using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Schools.Queries
{
    public class SchoolDto : IMapFrom<School>
    {
        public SchoolDto()
        {
            Campuses = new List<CampusDto>();
        }

        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Email { get; set; }
        public string CountryCode { get; set; }
        public decimal ApplicationFee { get; set; }
        public bool HasLeadIntegration { get; set; }
        public decimal IELTSlisten { get; set; }
        public decimal IELTSread { get; set; }
        public decimal IELTSwrite { get; set; }
        public decimal IELTSspeak { get; set; }
        public string PGWP { get; set; }

        public IList<CampusDto> Campuses { get; set; }

        public void Mapping(Profile profile)
        {
            // Special map
            profile.CreateMap<School, SchoolDto>().ForMember(s => s.Campuses, opt => opt.Ignore());

            profile.CreateMap<SchoolDto, School>()
                .ForMember(s => s.DomainEvents, opt => opt.Ignore())
                .ForMember(s => s.Created, opt => opt.Ignore())
                .ForMember(s => s.CreatedBy, opt => opt.Ignore())
                .ForMember(s => s.LastModified, opt => opt.Ignore())
                .ForMember(s => s.LastModifiedBy, opt => opt.Ignore())
                .ForMember(s => s.Archived, opt => opt.Ignore())
                .ForMember(s => s.Deleted, opt => opt.Ignore())
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}