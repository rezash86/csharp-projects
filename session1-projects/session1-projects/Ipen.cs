using System;
using System.Collections.Generic;
using System.Text;

namespace session1_projects
{
    interface Ipen
    {
        public string Color { get; set; }
        bool Open();
        bool Close();
        void Write(string text);
    }
}
