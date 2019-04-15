using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class Repository:IRepository
    {
        private DemoDBEntities db;

        public Repository(DemoDBEntities db)
        {
            this.db = db;
        }

     
        public List<FloorData> GetFloorSummary()
        {
            var sql = @" select Floor,roomtype.Description as RoomType,Status as Status,StatusPerRoomtype  from (
					 select job.Floor as Floor,job.RoomTypeId as RoomType,job.status as Status,sum(job.StatusNum) as StatusperRoomtype 
                     from rx_job job					
                     group by job.Floor, job.RoomTypeId, job.Status 
					 )result
					 inner join RX_RoomType roomtype
					 on result.RoomType = roomtype.Id
					 order by Floor";
            var data = db.Database.SqlQuery<FloorData>(sql).ToList();
            return data;           
        }      

    }
}