using Logistics.Shipping.Abstractions.Pudo;
using Logistics.Shipping.Api;
using Logistics.Shipping.Providers.Singpost;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var settings = builder.Configuration.GetSection("ProviderConfig").Get<AppSettings>();
builder.Services.AddSingleton(settings);

// Add out providers... nice and simple!
builder.Services.AddSingleton<IPudoProvider, SingPostClient>();
builder.Services.AddAsendiaServiceProviders();
builder.Services.AddDpdPudoProvider("DpdPudoProvider", new Logistics.Shipping.Providers.Dpd.DpdClientConfig { 
    ApiKey = "apiKey" 
});
builder.Services.AddDpdShipmentProvider(new Logistics.Shipping.Providers.Dpd.DpdClientConfig
{
    ApiKey = "apiKey"
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
