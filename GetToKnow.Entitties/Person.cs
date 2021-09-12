using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetToKnow.Entitties
{
    /// <summary>
    /// Details of a person
    /// </summary>
    public class Person
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

    }

    /// <summary>
    /// Location Specifiers
    /// </summary>
    public class Location
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class Data
    {
        [JsonProperty("persons")]
        public Person[] Persons { get; set; }
    }
}
