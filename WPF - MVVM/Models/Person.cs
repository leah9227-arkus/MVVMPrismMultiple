using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WPF___MVVM.Models
{
    public class PersonCollection : ObservableCollection<Person> { }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }

        public Person(int Id, string Name, string Lastname, string Email)
        {
            this.Id = Id;
            this.Name = Name;
            this.Lastname = Lastname;
            this.Email = Email;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
