using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    internal class Courier
    {
        public Courier(string id, string name, bool isAvaliable)
        {
            Id = id;
            Name = name;
            IsAvaliable = isAvaliable;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsAvaliable { get; set; }
    }
}
