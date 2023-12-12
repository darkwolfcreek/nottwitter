using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NotTwitter.Data;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Define and add the IpInfoService
builder.Services.AddHttpClient<IpInfoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

// Define the IpInfoService class
public class IpInfoService
{
    private readonly HttpClient _httpClient;

    public IpInfoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IpInfoResponse> GetIpInfo()
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<IpInfoResponse>("https://ipinfo.io/json");
            return response;
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., log them or return null)
            return null;
        }
    }
}

public class IpInfoResponse
{
    public string Ip { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public string Loc { get; set; }
    public string Org { get; set; }
    public string Postal { get; set; }
    public string Timezone { get; set; }
}
