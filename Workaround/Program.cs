using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Concrete;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            SelamVer();

            PttManager pttManager = new PttManager(new PersonManager());
            person.PersonalIdentity = 1234;
            person.FirstName = "TURAN EDİZ";
            person.LastName = "SAÇAKLI";
            person.BirthOfYear = 1900;
            pttManager.GiveMask(person);

            Console.ReadLine();

        }
        static void SelamVer()
        {
            Console.WriteLine("selam turan");
        }



    }
}
