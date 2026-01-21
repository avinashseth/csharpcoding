var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    //string lunchTime = builder.Configuration["CanteenSettings:LunchStart"];

    //return "Lunch time is: " + lunchTime;

    //int personAge = 40;

    string language = builder.Configuration["CanteenSettings:language"];

    if (language == "hi")
    {

        return "नमस्ते, स्वागत है";

    }
    else if (language == "tn")
    {
        return "வணக்கம், வரவேற்கிறோம்";
    }
    else
    {

        return "Hello, welcome";
    }

});

app.Run();
