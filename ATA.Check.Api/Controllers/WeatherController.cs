﻿using ATA.Check.Api.Controllers.Filters;
using ATA.Check.Shared;
using Bit.OData.ODataControllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATA.Check.Api.Controllers
{
    public class WeatherController : DtoController
    {
        static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [Function]
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            var rng = new Random();

            return Enumerable
                .Range(1, 5)
                .Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
        }
    }
}
