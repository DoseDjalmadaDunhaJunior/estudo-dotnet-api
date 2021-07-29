using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                EventoId = 1,
                Tema = "Prostituição e Drogas",
                Local = "Puteiro em João Pessoa",
                Lote = "1º Lote",
                QuantidadePessoas = 8000,
                DataEvento = DateTime.Now.AddDays(365).ToString("dd/mm/yyyy"),
                URL = "clonacartao.png"
                },
                new Evento(){
                EventoId = 2,
                Tema = "Aborto e Golpe Militar",
                Local = "Delegacia",
                Lote = "2º Lote",
                QuantidadePessoas = 24,
                DataEvento = DateTime.Now.AddDays(1).ToString("dd/mm/yyyy"),
                URL = "distintivo.png"
                }
            };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "teste2 post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"teste3 put com id = {id}";
        }        
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"teste3 Delete com id = {id}";
        }
    }
}
