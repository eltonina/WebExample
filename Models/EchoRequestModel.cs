using System;

namespace Web.Example.Models
{
    public class EchoRequestModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public bool Enabled { get; set; }
    }
}
