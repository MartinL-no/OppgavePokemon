
using Microsoft.AspNetCore.Mvc;

namespace OppgavePokemon.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game theGame = new Game();
            
            //Server stuff under here
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add services to the container.
            builder.Services.AddAuthorization();

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

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("/pokemons/magikarp", () =>
            {
                Console.WriteLine("********* Magikarp called*******");
                return new JsonResult(theGame.Magikarp);
            });

            app.MapGet("/pokemons", (string pokemonName) =>
            {
                return new JsonResult(theGame.GetPokemon(pokemonName));
            });

            app.MapGet("/pokemons/attack", (string pokemonName) =>
            {
                var pokemon = theGame.GetPokemon(pokemonName);
                pokemon.Attack(theGame.Magikarp);

                return new JsonResult( theGame.Magikarp);
            })
            .WithName("GetPokemon")
            .WithOpenApi();

            app.Run();
        }
    }
}