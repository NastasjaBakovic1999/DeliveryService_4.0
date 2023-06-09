﻿using DeliveryServiceDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceData.Implementation
{
    public class RepositoryAdditionalService : GenericRepository<AdditionalService>, IRepositoryAdditionalService
    {
        public RepositoryAdditionalService(DbContext context) : base(context)
        {
        }
    }
}
