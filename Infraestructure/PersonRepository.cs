using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

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

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        // retornar campos especificos
        public IEnumerable<Object> GetField(){
            var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age *-1).Year,
                CorreoElectronico = person.Email
            });
            return query;
        }

        // retornar elementos que sean iguales
        public IEnumerable<Person> GetByGender(char gender){
            //var gender = 'M';
            var query = _persons.Where(person => person.Gender == gender);
            return query;
        }
        
        public IEnumerable<Person> GetByMaxAge(int age){
            //var age = 30;
            var query = _persons.Where(person => person.Age <= age);
            return query;
        }
        // Retornar elementos que sean diferentes
        public IEnumerable<Person> GetDiference(){
            var job = "Civil Engineer";
            var query = _persons.Where(person => person.Job != job);
            return query;
        }
        
        public IEnumerable<string> GetJobs(){
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        }
        // retornar valores que contengan
        public IEnumerable<Person> GetContains(string partName){
            //var partName = "ar";
            var query = _persons.Where(person => person.FirstName.Contains(partName));
            return query; //no me importa donde lo contenga
        }

        public IEnumerable<Person> GetByAger(int firstAge, int secondAge, int thirdAge){
            var ages = new List<int>{firstAge,secondAge,thirdAge};
            var query = _persons.Where(person => ages.Contains(person.Age));
            return query; 
        }
        // retornar valores entre un rango
        public IEnumerable<Person> GetByRangeAge(int minage, int maxage){
            //var minage = 30;
            //var maxage = 40;
            var query = _persons.Where(person => person.Age >= minage && person.Age <= maxage);
            return query;
        }

        // retornar elementos ordenados
        public IEnumerable<Person> GetPersonsOrdered(int age){
            var query = _persons.Where(person => person.Age > age)
                        .OrderBy(person => person.Age);
            return query;
        }
        
        public IEnumerable<Person> GetPersonsOrderedDesc(char gender, int minage, int maxage){
            var query = _persons.Where(person => person.Gender == gender && person.Age >= minage && person.Age <= maxage)
                        .OrderByDescending(person => person.Age);
            return query;
        }
        
        // retorno cantidad de elementos
        public int CountPeople(){
            var age = 37;
            var query = _persons.Count(person => person.Age == age);
            return query;
        }
        
        public int CountPerson(char gender)
        {
            //var gender = 'F';
            var query = _persons.Count(person => person.Gender == gender);
            return query;
        }
        // Evalua si un elemento existe
        public bool ExistPerson(string lastName)
        {
            //var lastName = "Tuffell";
            var query = _persons.Exists(person => person.LastName == lastName);
            return query;
        }

        // retornar solo un elemento
        public Person GetPerson(string job, int age)
        {
            var query = _persons.FirstOrDefault(person => person.Job == job && person.Age == age);
            return query;
        }

        // retornar solamente unos elementos
        public IEnumerable<Person> TakePerson(string job, int totake)
        {
            //var job = "Geological Engineer";
            //var take = 3;
            var query = _persons.Where(person => person.Job == job).Take(totake);
            return query;
        }

        public IEnumerable<Person> TakeLastPerson()
        {
            var job = "Geological Engineer";
            var take = 3;
            var query = _persons.Where(person => person.Job == job).TakeLast(take);
            return query;
        }
        // retornar elementos saltando posición
        public IEnumerable<Person> SkipPerson(string job, int skip)
        {
            //var job = "Professor";
            //var skip = 4;
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            return query;
        }
        public IEnumerable<Person> SkipTakePerson(string job, int skip, int totake)
        {
            //var job = "Professor";
            //var skip = 4;
            //var take = 3;
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(totake);
            return query;
        }
        
    }
}