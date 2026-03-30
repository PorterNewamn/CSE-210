using System.Diagnostics.Contracts;

public class Info : Event
{
    private string _speakerName;
    private int _capacity; 
    private string _weather;
    private string _type;
    Random random = new Random();

    List<string> weather = new List<string>
    {
        "98 deegrees, Partly cloudy, Low Winds avg 2 mph",
        "65 degrees, Sunny, Low Winds 2 mph",
        "72 degrees, Rainy, High Winds of 16 MPH",
        "45 degrees, Foggy, Calm Winds 0 mph",
        "88 degrees, Humid, Moderate Winds avg 8 mph",
        "31 degrees, Snowing, High Winds of 22 MPH",
        "75 degrees, Clear Skies, Low Winds 3 mph",
        "58 degrees, Overcast, Breezy Winds 12 mph",
        "102 degrees, Scorching, Low Winds avg 5 mph",
        "67 degrees, Scattered Showers, Moderate Winds 10 mph",
        "24 degrees, Blistering Cold, High Winds of 25 MPH",
        "82 degrees, Hazy, Low Winds 4 mph",
        "52 degrees, Drizzling, Moderate Winds avg 7 mph"
    };

    List<int> capacity = new List<int>
    {
        150,
        200,
        50,
        300,
        245,
        90,
        220,
        310,
        240,
        290,
        120

    };

    List<string> name = new List<string>
    {
        "Bob Martin",
        "Tobby Hangardner",
        "Tom Riddle",
        "Jordan Afton",
        "Monk Tinner",
        "Jerry Wheeler",
        "Gogs Crospy",
        "Chick Alfredo"
    };

    public Info(){}

    public void SetType(string type)
    {
        _type = type;
    }

    public void ShortDescription()
    {
        Console.WriteLine(_type);
        Title();
        Date();
    }

    

    public void RunInfo()
    {
        if (_type == "Lectures")
        {
            SetCapacity();
            SetSpeakerName();
            Title();
            Console.WriteLine(_type);
            Description();
            Console.WriteLine(_speakerName);
            Console.WriteLine($"Capacity: {_capacity} ");
            Date();
            Time();
            DisplayAddress(1);
        }
        else if (_type == "Receptions")
        {
            Title();
            Console.WriteLine(_type);
            Description();
            Console.WriteLine($"=== RSVP ===");
            SetCapacity();
            Console.WriteLine($"Capacity: {_capacity} ");
            Date();
            Time();
            DisplayAddress(2);
        }
        else
        {
            Title();
            Console.WriteLine(_type);
            Description();
            SetWeather();
            Console.WriteLine($"Weahter report: {_weather}");
            Date();
            Time();
            DisplayAddress(0);
        }


    }

    public void SetWeather()
    {
        int randomIndex = random.Next(weather.Count());
        _weather = weather[randomIndex];
    }

    public void SetCapacity()
    {
        int randomIndex = random.Next(capacity.Count());
        _capacity = capacity[randomIndex];
    }

    public void SetSpeakerName()
    {
        int randomIndex = random.Next(name.Count());
        _speakerName = name[randomIndex];
    }
}