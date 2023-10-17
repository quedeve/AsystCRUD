using Asyst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asyst.Repository
{

    public interface IPersonRepository
    {
        List<Person> GetAll();
        Person Get(int id);
        void Add(Person person);
        void Update(int id, Person updatedPerson);
        void Delete(int id);
    }

}
