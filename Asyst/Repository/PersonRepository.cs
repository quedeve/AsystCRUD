using Asyst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asyst.Repository
{
    public class PersonRepository : IPersonRepository
    {
        //private List<Person> people = new List<Person>();
        //private int nextId = 1;
        private ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        public Person Get(int id)
        {
            return _context.Persons.FirstOrDefault(x => x.ID == id);
        }

        public void Add(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }

        public void Update(int id, Person updatedPerson)
        {
            var existingPerson = Get(id);
            if (existingPerson != null)
            {
                existingPerson.Name = updatedPerson.Name;
                existingPerson.Email = updatedPerson.Email;
            }
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var existingPerson = Get(id);
            if (existingPerson != null)
            {
                _context.Persons.Remove(existingPerson);
                _context.SaveChanges();
            }
        }
    }
}
