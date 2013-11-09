using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumingServices.Core.Models
{
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
