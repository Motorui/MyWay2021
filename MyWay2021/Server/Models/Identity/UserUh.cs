﻿using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Models.Identity
{
    public class UserUh
    {
        public Guid UhID { get; set; }
        public Uh Uh { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
