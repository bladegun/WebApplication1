using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;

namespace WebApplication1.Data
{
    [Table("table1")]
    public class Table1
    {
        public int id { get; set; }

        public string name { get; set; }

        public Point point { get; set; }
    }
}
