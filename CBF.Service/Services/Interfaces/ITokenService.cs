﻿using CBF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Service.Services.Interfaces
{
    public interface ITokenService
    {
        string GetToken(Usuario usuario);
    }
}
