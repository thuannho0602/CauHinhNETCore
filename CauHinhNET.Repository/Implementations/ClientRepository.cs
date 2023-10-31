﻿using CauHinhNET.DataAccess;
using CauHinhNET.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauHinhNET.Repository.Implementations
{
    public class ClientRepository:RepositoryBase<Client,ApplicationDbContext>,IClientRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
