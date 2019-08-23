using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalShelterAPIContext _db = new AnimalShelterAPIContext();
        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            
            return _db.Animals.ToList();
        }
        //POST api/animals
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);  
            _db.SaveChanges();
        }
        // GET api/animals/1
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _db.Animals.FirstOrDefault(x => x.AnimalId == id);
        }
        // PUT api/animals/1
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            animal.AnimalId = id;
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
        }
        // DELETE api/animals/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var thisAnimal = _db.Animals.FirstOrDefault(x => x.AnimalId == id);
            _db.Animals.Remove(thisAnimal);
            _db.SaveChanges();
        }
        //GET animals by breed
        [HttpGet("breed/{breed}")]
        public ActionResult<IEnumerable<Animal>> Get (string breed)
        {
            return _db.Animals.Where(x => x.AnimalBreed == breed).ToList();
        }
        // GETRandom api/animals/rnd#
        [HttpGet("{id}")]
        public ActionResult<Animal> GetRandom()
        {
            Random rnd = new Random();
            return _db.Animals.Find(rnd.Next(0,_db.Animals.Count()));
        }
    }
}