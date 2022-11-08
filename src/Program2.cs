// BUSCAR PACIENTES SEGUN SU NOMBRE

namespace FHIR_TEST
{
    using System;
    using System.Collections.Generic;
    using Hl7.Fhir.Model;
    using Hl7.Fhir.Rest;
    using Hl7.Fhir.Serialization;
    /// <summary>
    /// Main program
    /// </summary>

    public static class Program
    {
        private const string _fhirServer = "http://hapi.fhir.org/baseR4/"; // "http://vonk.fire.ly";

        static void Main(string[] args)
        {
            FhirClient fhirClient = new FhirClient(_fhirServer)
            {
                PreferredFormat = ResourceFormat.Json,
                PreferredReturn = Prefer.ReturnRepresentation
            };

            //Bundle patientBundle = fhirClient.Search<Patient>(new string[] {"name=maria"}); //Buscar por nombre del paciente (sin importar tildes y mayus)
            //Bundle patientBundle = fhirClient.Search<Patient>(new string[] {"identifier=43798506"}); //Buscar por DNI del paciente
            //Bundle patientBundle = fhirClient.Search<Patient>(new string[] {"family=anconetani"}); //Buscar por apellido del paciente
            //Bundle patientBundle = fhirClient.Search<Patient>(new string[] {"family=anconetani", "name=mario"}); //Buscar por nombre y apellido
            Bundle patientBundle = fhirClient.Search<Patient>(new string[] {"name=maria","family=anconetani", "identifier=43798505"}); //Buscar por nombre, apellido y DNI

            Console.WriteLine($"Total: {patientBundle.Total} Entry count: {patientBundle.Entry.Count}");

            int patientNumber = 0;

            foreach (Bundle.EntryComponent entry in patientBundle.Entry)
            {
                Console.WriteLine($"- Entry {patientNumber,3}: {entry.FullUrl}");

                if (entry.Resource != null)
                {
                    Patient patient = (Patient)entry.Resource;
                    Console.WriteLine($"- Id: {patient.Id,20}");

                    if (patient.Name.Count > 0)
                    {
                        Console.WriteLine($" - Name: {patient.Name[0].ToString()}");
                    }

                }
                
                patientNumber++;
            }

        }
    }
}
