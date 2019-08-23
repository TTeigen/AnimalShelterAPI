using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelterAPI.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId {get;set;}
        public string Name {get;set;}
        public string AnimalBreed {get;set;}
        public int Age {get;set;}
    }
}
