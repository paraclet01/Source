﻿using OPTICIP.API.Application.Queries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPTICIP.API.Application.Queries.Interfaces
{
    public interface IRequetesDiverses
    {
        Task<bool> TruncateTable(String pTableName);
    }
}
