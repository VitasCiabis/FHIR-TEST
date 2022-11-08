// CREAR PACIENTE
/*
namespace MyFirstFhirClient
{
    using System;
    using System.Collections.Generic;
    using Hl7.Fhir.Model;
    using Hl7.Fhir.Rest;
    using Hl7.Fhir.Serialization;
    /// <summary>
    /// Main program
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creacion de paciente Fhir");

            var patient = new Patient()
            {
                Name = new List<HumanName>()
                {
                    new HumanName()
                    {
                        Given = new List<string>{"Mario","Victoria" },
                        Family = "Anconetani"
                    }
                },
                Gender = AdministrativeGender.Female,
                BirthDate = "2001-09-25",
                Identifier = new List<Identifier>()
                {
                    new Identifier()
                    {
                        Value = "43798506"
                    }
                }
            };
            Console.WriteLine($"Sending patient {patient.Name[0].Given.FirstOrDefault()} {patient.Name[0].Family} ....");

            var client = new FhirClient("http://hapi.fhir.org/baseR4/");
            client.Create(patient);

            Console.WriteLine($"Result: {client.LastResult.Status}");
        }
    }
}

*/