var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string Policy_1_React_Integration = "_Policy_1_React_Integration";

builder.Services.AddCors(options =>
{
    options.AddPolicy("_Policy_1_React_Integration",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyOrigin()
                    .WithMethods("GET");
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Enable Cors
app.UseCors(Policy_1_React_Integration);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
