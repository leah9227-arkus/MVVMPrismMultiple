using System;
using System.Collections.Generic;
using System.Text;
using WPF___MVVM.Models;

namespace WPF___MVVM.Business
{
    class DatabasConnection
    {
        public PersonCollection ListPersons()
        {
            PersonCollection persons = new PersonCollection();
            persons.Add(new Person(1, "Juanito", "LastName", "juanito@gmail.com"));
            persons.Add(new Person(2, "Chachito", "LastName", "chachito@gmail.com"));
            persons.Add(new Person(3, "Chetito", "LastName", "chetito@gmail.com"));
            persons.Add(new Person(4, "Frodo", "LastName", "frodo@gmail.com"));
            return persons;
        }

        public bool DeletePerson(Person person)
        {
            return true;
        }
    }
}
