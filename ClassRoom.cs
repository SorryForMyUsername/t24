using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_1
{
    class ClassRoom
    {
        List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = pupils.ToList();
        }

        public void OutputPupils()
        {
            foreach(Pupil p in pupils)
            {
                Console.WriteLine($"Ученик {p.Name}:");
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }
        }
    }
}
