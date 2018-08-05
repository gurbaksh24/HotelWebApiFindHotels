using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebApi.Models
{
    public class RootObjectPrediction
    {
        public List<CityAutoComplete> Predictions { get; set; }
    }
}