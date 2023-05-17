using Bogus;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Bogus
{
    internal class BogusSeeding
    {
        public static IReadOnlyCollection<Employees> Employees { get; set; } = new List<Employees>();
      
        public static IReadOnlyCollection<Roles> Roles { get; set; } = new List<Roles>();
        
        public static IReadOnlyCollection<HasRoles> HasRoles { get; set; } = new List<HasRoles>();

        private const int EMPLOYEES = 100;

        private const int HAS_ROLES = 50;

        private const int ROLES = 5;

        public BogusSeeding()
        {
            SeedingEmployees();
        }

        private static IReadOnlyCollection<Employees> SeedingEmployees()
        {
            Employees = new Faker<Employees>()
                .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                .RuleFor(x => x.LastName, f => f.Person.LastName)
                .RuleFor(x => x.Email, (f, o) => f.Internet.Email(o.FirstName, o.LastName))
                .RuleFor(x => x.Mobile, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.Password, f => f.Internet.Password())
                .RuleFor(x => x.ActiveIs, f => f.Random.Bool())
                .Generate(EMPLOYEES);

            return Employees;
        }

        private static IReadOnlyCollection<Roles> SeedingRoles()
        {
            Roles = new Faker<Roles>().Generate(ROLES);

            var Roles_types = Enum.GetNames(typeof(Roles_types));

            for (int i = 0; i < Roles.Count; i++) { Roles[i].Role_title = Roles_types[i]; }

            return Roles;
        }
    }
}
