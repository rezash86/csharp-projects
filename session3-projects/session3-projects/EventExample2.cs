using System;
using System.Collections.Generic;
using System.Text;

namespace session3_projects
{
    public class Metronome
    {
        public delegate void TickHandler(Metronome m, EventArgs e);
        public event TickHandler Tick;
        public EventArgs e = null;

        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }

    public class Listener
    {
        public void Subscribe(Metronome m)
        {
            m.Tick += new Metronome.TickHandler(HeardIt);
        }

        public void HeardIt(Metronome m, EventArgs e)
        {
            Console.WriteLine("I heard it");
        }
    }
}
