﻿using Microsoft.AspNetCore.Mvc;
using Notification.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Notification.WebUI.Controllers;

namespace WebUI.Controllers;

/// <summary>
/// Weather forecast controller
/// </summary>
[Area("WebApi")]
public class WeatherForecastController : ApiControllerBase
{
    /// <summary>
    /// WeatherForecast Get
    /// </summary> 
    /// <returns></returns>
    [HttpGet, Route("~/WebApi/WeatherForecast/Get")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}