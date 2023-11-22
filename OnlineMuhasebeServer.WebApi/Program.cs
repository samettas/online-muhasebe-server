using Microsoft.AspNetCore.Identity;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.WebApi.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServices(
    builder.Configuration, typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if(!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "samet",
            Email = "admin@gmail.com",
            Id = Guid.NewGuid().ToString(),
            NameLastName = "Samet Tas",
        },"admin").Wait();
  
    }
}

app.Run();
