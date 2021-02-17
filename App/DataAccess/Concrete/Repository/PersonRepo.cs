using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Repository
{
    public class PersonRepo
    {

        public List<Person> GetList()
        {
            return new DbContext<Person>().GetList("SELECT * FROM public.person order by id desc").ToList();
        }

        public bool AddPerson(Person person)
        {
            return new DbContext<Person>().Insert("INSERT INTO public.person (Name,Surname,Phone,Adress,BloodGroup) VALUES (@Name,@Surname,@Phone,@Adress,@BloodGroup)", person);
        }
    }
}
