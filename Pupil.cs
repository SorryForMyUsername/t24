using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_1
{
    abstract class Pupil
    {
        string name;

        public string Name { get => name; set => name = value; }

        public Pupil(string name)
        {
            Name = name;
        }

        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }
}
