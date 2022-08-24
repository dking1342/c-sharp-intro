using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
    // builder.Services.AddSingleton<IBreakfastService, BreakfastService>();
    // builder.Services.AddTransient<IBreakfastService, BreakfastService>();
}

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseHsts();

    // app.UseStatusCodePages();
    app.UseStatusCodePagesWithRedirects("/error-handler");

    // app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

