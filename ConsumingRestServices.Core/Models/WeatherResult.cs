using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumingServices.Core.Models
{
    public class WeatherResult
    {
        public string cod { get; set; }
        public double message { get; set; }
        public City city { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
    }
}
