﻿using Dapper;
using SupplierWebApp.Models;
using SupplierWebApp.Queries.Contracts;
using SupplierWebApp.Queries.ReadRepository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
namespace SupplierWebApp.Queries.ReadRepository
{
    public class BidTypeQueries : BaseRepository<BidType>, IBidTypeQueries
    {

        private string _connectionString = string.Empty;

        public BidTypeQueries(string constr) : base(constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));

        }



    }
}

