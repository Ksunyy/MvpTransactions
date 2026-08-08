var builder = WebApplication.CreateBuilder(args); // возвращает строителя

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<UserService>();
builder.Services.AddSwaggerGen();

var app = builder.Build(); // возвращает приложение


app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();


app.Run();
