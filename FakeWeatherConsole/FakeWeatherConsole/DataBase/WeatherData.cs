using System.Data;

namespace FakeWeatherConsole.DataBase;

/// <summary>
/// Class that stores weather information
/// </summary>
public class WeatherData
{
    public DataTime RequestTime { get; set; }
    public int Temperature { get; set; }

    public WeatherData(DataTime requestTime, int temperature)
    {
        RequestTime = requestTime;
        Temperature = temperature;
    }
}