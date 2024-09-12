using MassTransit;
using Newtonsoft.Json.Converters;
using SupportFlow.ChainOfResponsibility;
using SupportFlow.MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.Converters.Add(new StringEnumConverter()));
var technicalHandler = new TechnicalSupportHandler();
var billingHandler = new BillingSupportHandler();
var generalHandler = new GeneralSupportHandler();

technicalHandler.SetNext(billingHandler);
billingHandler.SetNext(generalHandler);

var supportHandler = technicalHandler; 

builder.Services.AddSingleton<ISupportRequestHandler>(supportHandler);
builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<SupportRequestConsumer>();

    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", 5672, "/", h =>
        {
            h.Username("guest"); 
            h.Password("guest"); 
        });

        cfg.ReceiveEndpoint("support_request_queue", e =>
        {
            e.ConfigureConsumer<SupportRequestConsumer>(context); 
        });
    });
});


builder.Services.AddMassTransitHostedService();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

