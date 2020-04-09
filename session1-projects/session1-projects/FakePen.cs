using System;
using System.Collections.Generic;
using System.Text;

namespace session1_projects
{
    class FakePen : Ipen, IPencil, IBrandedPen
    {
        string Ipen.Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        bool Ipen.Close()
        {
            throw new NotImplementedException();
        }

        string IBrandedPen.GetBrandName()
        {
            return "I am branded";
        }

        bool Ipen.Open()
        {
            throw new NotImplementedException();
        }

        void IPencil.Write()
        {
            throw new NotImplementedException();
        }

        void Ipen.Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
