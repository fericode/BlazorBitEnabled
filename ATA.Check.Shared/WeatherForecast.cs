﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATA.Check.Shared
{
    [ComplexType]
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
