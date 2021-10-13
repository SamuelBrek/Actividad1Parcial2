using System;

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

namespace QueryApi.Domain
{
    public record Person(int Id, string FirstName, string LastName, string Email, char Gender, string Job, int Age);
}