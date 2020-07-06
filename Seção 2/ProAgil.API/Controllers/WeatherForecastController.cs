using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProAgil.API.Data;
using ProAgil.API.Model;
//using ProAgil.Respository;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        //GET ALL
        [HttpGet]

        public ActionResult<IEnumerable<Evento>> Get()
        {

            return _context.Eventos.ToList();

            // return new Evento[] {
            //     new Evento (){
            //         EventoId=1,
            //         Tema = "Angular e .Net Core",
            //         Local = "Belo Horizonte",
            //         Lote="1º Lote",
            //         QtdPessoas=250,
            //         DataEvento= DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            //     },
            //     new Evento (){
            //         EventoId=2,
            //         Tema = "Angular e suas novidades",
            //         Local = "São Paulo",
            //         Lote="2º Lote",
            //         QtdPessoas=350,
            //         DataEvento= DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
            //     }

            //  };
        }
        //GET by ID
        [HttpGet("{id}")]

        public ActionResult<Evento> Get(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
            // return new Evento[] {
            //     new Evento (){
            //         EventoId=1,
            //         Tema = "Angular e .Net Core",
            //         Local = "Belo Horizonte",
            //         Lote="1º Lote",
            //         QtdPessoas=250,
            //         DataEvento= DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            //     },
            //     new Evento (){
            //         EventoId=2,
            //         Tema = "Angular e suas novidades",
            //         Local = "São Paulo",
            //         Lote="2º Lote",
            //         QtdPessoas=350,
            //         DataEvento= DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
            //     }

            //  }.FirstOrDefault(x => x.EventoId == id);
        }

        //httpget
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }
    }
}
