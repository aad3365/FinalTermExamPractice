using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Person
    {
        public string firstName;
        public string lastName;

        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }
    }

    class People : IEnumerable
    {
        private Person[] people;
        public People(Person[] people)
        {
            this.people = new Person[people.Length];

            for (int i = 0; i < people.Length; i++)
            {
                this.people[i] = people[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new PeopleEnum(this.people);
        }
    }
    class PeopleEnum : IEnumerator
    {
        public Person[] people;
        int position = -1;

        public PeopleEnum(Person[] list)
        {
            people = list;
        }

        public object Current
        {
            get {
                try
                {
                    return people[position];
                } catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < people.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }

}
