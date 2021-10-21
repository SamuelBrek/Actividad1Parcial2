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
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("getField")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetByGender/{gender}")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("GetByMaxAge/{age}")]
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
        [Route("GetByRangeAge/{minage}/{maxage}")]
        public IActionResult GetByRangeAge(int minage, int maxage)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge(minage, maxage);
            return Ok(persons);
        }


        [HttpGet]
        [Route("GetJobs")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("GetContains/{partName}")]
        public IActionResult GetContains(string partName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(partName);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("GetByAger/{firstAge}/{secondAge}/{thirdAge}")]
        public IActionResult GetByAger(int firstAge, int secondAge, int thirdAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAger(firstAge, secondAge, thirdAge);
            return Ok(persons);
        }

        
        
        [HttpGet]
        [Route("GetPersonsOrdered/{age}")]
        public IActionResult GetPersonsOrdered(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered(age);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("GetPersonsOrderedDesc/{gender}/{minage}/{maxage}")]
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
        [Route("CountPerson/{gender}")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("ExistPerson/{lastName}")]
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
        [Route("GetPerson/{job}/{age}")]
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
        [Route("TakePerson/{job}/{totake}")]
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
        [Route("SkipPerson/{job}/{skip}")]
        public IActionResult SkipPerson(string job, int skip)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job, skip);
            return Ok(persons);
        }
    
        [HttpGet]
        [Route("SkipTakePerson/{job}/{skip}/{totake}")]
        public IActionResult SkipTakePerson(string job, int skip, int totake)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job, skip, totake);
            return Ok(persons);
        }


    }
}