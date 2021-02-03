using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly UnitOfWork uow;
        private readonly IConfiguration _config;
        public ItemController(UnitOfWork unitOfWork, IConfiguration config)
        {
            uow = unitOfWork;
            _config = config;
        }

        //[HttpPost("UpdateHoliday")]
        //public async Task<ActionResult<HolidayViewModel>> SearchForItwm(string itemNo)
        //{
        //}



        }
}
