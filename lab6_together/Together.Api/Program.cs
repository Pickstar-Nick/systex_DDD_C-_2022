using Together.Appliction.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IEventService,EventService>();
}
//與Swagger相關
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//與Swagger相關
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
{
    app.UseHttpsRedirection();

    //app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
