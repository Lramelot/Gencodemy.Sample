using System.Linq;
using Gencodemy.Core.Domains;
using Gencodemy.Core.Exceptions;
using Gencodemy.Services.Persons.Commands;

namespace Gencodemy.Services.Persons
{
    public class PersonsService
    {
        public Person CreatePerson(CreatePerson command)
        {
            if (string.IsNullOrWhiteSpace(command.Name))
            {
                throw new ValidationException($"Le champs {nameof(command.Name)} ne peut être vide");
            }

            if (string.IsNullOrWhiteSpace(command.Firstname))
            {
                throw new ValidationException($"Le champs {nameof(command.Firstname)} ne peut être vide");
            }

            if (command.PhoneNumber.Length > 11)
            {
                throw new ValidationException($"Le champs {command.PhoneNumber} ne peut être constitué que de 11 caractères maximum");
            }

            if (command.PhoneNumber.Any(char.IsLetter))
            {
                throw new ValidationException($"Le champs {command.PhoneNumber} ne peut contenir que des chiffres");
            }

            var person = new Person()
            {
                PhoneNumber = command.PhoneNumber,
                Name = command.Name,
                Firstname = command.Firstname,
            };

            return person;
        }
    }
}