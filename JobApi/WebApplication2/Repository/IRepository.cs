using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public interface IRepository
    {
        List<FloorData> GetFloorSummary();
    }
}