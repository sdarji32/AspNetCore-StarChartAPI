﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]

    public class CelestialObjetController
    {
        private readonly ApplicationDbContext _context;
        public CelestialObjetController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
