//Brandon Le
//10-25-22
//Mini Challenge 4 - Asking Questions
//Web API project that will take the users two inputs in the url and take the two inputs and print them out in the statement:
//Hello {name}! It's nice to finally meet you! Wow you woke up at {time} AM?! That's impressive! The early bird gets the worm :)
//For example if it's MiniCh4/Asking/Brandon/5 the outcome would be Hello Brandon. It's nice to finally meet you! Wow you woke up at 5AM?! That's impressive! The early bird gets the worm :)
//Peer Review: This program works well it displays a good amount of text about the user's name and time they woke. It is way better than my one liner that is bland and boring and not good and god I wish I was as good as Brandon. Good job. 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
