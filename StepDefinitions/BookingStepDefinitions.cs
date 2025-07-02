namespace reqnroll_api_testing.StepDefinitions;
using Microsoft.Extensions.Configuration;
using Reqnroll;
using static RestAssured.Dsl;

[Binding]
public class BookingStepDefinitions
{
    private readonly string _baseUrl;

    public BookingStepDefinitions()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        _baseUrl = config["BookingApi:BaseUrl"]!;
    }

    [Given("the booking service is available")]
    public async Task GivenTheBookingServiceIsAvailable()
    {
        // Check if the booking service is available by sending a GET request to the endpoint
            Given()
            .When()
            .Get($"{_baseUrl}")
            .Then()
            .StatusCode(200);
    }

    [When("the user provides valid room and guest details")]
    public async Task WhenTheUserProvidesValidRoomAndGuestDetails()
    {
        // TODO: Implement sending booking request
        await Task.CompletedTask;
    }

    [Then("the booking should be successful")]
    public async Task ThenTheBookingShouldBeSuccessful()
    {
        // TODO: Implement booking success verification
        await Task.CompletedTask;
    }
}