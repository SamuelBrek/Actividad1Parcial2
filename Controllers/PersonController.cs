using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

/*
Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Actividad 1
Nombre del alumno: Brek Mejia Samuel Alexander
Cuatrimestre: 4
Grupo: B
Parcial: 2
*/

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("Obtener Todos")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Obtener informacion")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Obtener por genero")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Edad Maxima")]
        public IActionResult GetByMaxAge(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByMaxAge(age);
            return Ok(persons);
        } 
        /*
        [HttpGet]
        [Route("")]
        public IActionResult GetDiference()
        {
            var repository = new PersonRepository();
            var persons = repository.GetDiference();
            return Ok(persons);
        } */

        [HttpGet]
        [Route("Rango de edad")]
        public IActionResult GetByRangeAge(int minage, int maxage)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge(minage, maxage);
            return Ok(persons);
        }


        [HttpGet]
        [Route("Todos los trabajos")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Palabras contenidas en el nombre")]
        public IActionResult GetContains(string partName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(partName);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Especificar 3 edades")]
        public IActionResult GetByAger(int firstAge, int secondAge, int thirdAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAger(firstAge, secondAge, thirdAge);
            return Ok(persons);
        }

        
        
        [HttpGet]
        [Route("Ordenar por edad a partir de una especificada")]
        public IActionResult GetPersonsOrdered(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered(age);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Ordenar descendentemente indicando genero y rango de edad")]
        public IActionResult GetPersonsOrderedDesc(char gender, int minage, int maxage) //Lo he ordenado por edad descendentemente
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDesc(gender, minage, maxage);
            return Ok(persons);
        }
        
        /*

        [HttpGet]
        [Route("")]
        public IActionResult CountPeople()
        {
            var repository = new PersonRepository();
            var persons = repository.CountPeople();
            return Ok(persons);
        }
        */
        [HttpGet]
        [Route("Contar cuantas personas existen de un genero")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Si existen personas con cierto apellido")]
        public IActionResult ExistPerson(string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(lastName);
            return Ok(persons);
        }
        /*
        [HttpGet]
        [Route("")]
        public IActionResult AnyPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.AnyPerson();
            return Ok(persons);
        }
        */
        [HttpGet]
        [Route("Una persona de cierto trabajo y cierta edad")]
        public IActionResult GetPerson(string job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson(job, age);
            return Ok(persons);
        }
        /*
        [HttpGet]
        [Route("")]
        public IActionResult GetPerson2()
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson2();
            return Ok(persons);
        }
        */
        [HttpGet]
        [Route("Tomar las primeras X personas de X trabajo")]
        public IActionResult TakePerson(string job, int totake)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(job, totake);
            return Ok(persons);
        }
        /*
        [HttpGet]
        [Route("")]
        public IActionResult TakeLastPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.TakeLastPerson();
            return Ok(persons);
        }
        */
        [HttpGet]
        [Route("Omitir informacion de X personas de X trabajo")]
        public IActionResult SkipPerson(string job, int skip)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job, skip);
            return Ok(persons);
        }
    
        [HttpGet]
        [Route("Obtener informacion de X personas omitiendo X personas de X trabajo")]
        public IActionResult SkipTakePerson(string job, int skip, int totake)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job, skip, totake);
            return Ok(persons);
        }


    }
}