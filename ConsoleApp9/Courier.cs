using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Courier
    {
        public Courier(string name)
        {
            Id = ++id;
            Name = name;
            IsAvaliable = true;
        }

        private static int id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public bool IsAvaliable { get; set; }
    }
}
