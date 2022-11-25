﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interfaces
{
    public interface IAccountService
    {
        bool Register(User user);

        User GetUserByID(int id);

    }
}
