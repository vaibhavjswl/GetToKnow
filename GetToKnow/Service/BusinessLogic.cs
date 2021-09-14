using GetToKnow.Entitties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace GetToKnow.Service
{
    public class BusinessLogic
    {
        private Data persons { get; set; }
        public BusinessLogic()
        {
            string fileText = File.ReadAllText("./Service/json.json");
            persons = JsonConvert.DeserializeObject<Data>(fileText);
        }

        //Get a person from database
        public (Person, bool) GetPerson()
        {
            var index = new Random().Next(0,persons.Persons.Length);
            try
            {
                var data = this.persons.Persons.ToArray()[index];
                return (data, true);
            }
            catch (Exception)
            {
                return (new Person() {FirstName="John", LastName="Snow"}, false);
            }

        }
    }
}
