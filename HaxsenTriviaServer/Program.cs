using HaxsenTriviaServer.Services;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Note: ONLY FOR SECURITY, we dont need this for sample.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        builder => builder
            .WithOrigins("https://triviawebgamefrontend.onrender.com")
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddControllers();
builder.Services.AddRefitClient<IOpenTdbClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://opentdb.com")); // we can also create env vars lib
builder.Services.AddScoped<ITriviaService, TriviaService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

// Note: ONLY FOR SECURITY, we dont need this for sample.
app.UseCors("AllowReactApp");
//app.UseCors("AllowAll"); // in case we want to use `*`

app.MapControllers();

app.Run();
