using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Repository;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{

    public class FloorController : ApiController
    { 
        private IRepository _repo;
      
        public FloorController(IRepository repo)
        {
            _repo = repo;
        }

        //Get api/Floor       
     
        public List<FloorData> GetRoomTypes()

        {            
            return _repo.GetFloorSummary();
           
        }
    }
}
