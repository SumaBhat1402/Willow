using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class FloorData
    {
        public int Floor { get; set; }
        public string Status { get; set; }
        public string RoomType { get; set; }
        public int StatusPerRoomtype { get; set; }
    }
}