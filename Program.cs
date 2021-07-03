var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var counter = 0;
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", (Func<string>)(() => "Welcome to .NET 6 Minimal API with C# 10!"));
app.MapGet("/counter", (Func<int>)(() => {
    counter++;
    return counter;
}));
app.Run();
