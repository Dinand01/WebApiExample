using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Serialization
{
    public class WebApiExampleDateTimeConverter : IsoDateTimeConverter
    {
        public WebApiExampleDateTimeConverter()
        {
            base.DateTimeFormat = "dd/MM/yyyy HH:mm";
        }
    }
}
