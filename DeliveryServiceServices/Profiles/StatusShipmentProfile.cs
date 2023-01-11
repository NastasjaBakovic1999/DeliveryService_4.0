﻿using AutoMapper;
using DataTransferObjects;
using DeliveryServiceDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceServices.Profiles
{
    public class StatusShipmentProfile:Profile
    {
        public StatusShipmentProfile()
        {
            CreateMap<StatusShipment, StatusShipmentDto>().ReverseMap();

        }
    }
}
