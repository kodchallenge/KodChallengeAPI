using Kod.WebAPI.Configs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.ConfigureLogging();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.ApplyConfiguration();

app.MapControllers();

app.Run();
