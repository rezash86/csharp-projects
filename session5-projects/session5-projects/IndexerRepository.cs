using System;
using System.Collections.Generic;
using System.Text;

namespace session5_projects
{
    class IndexerRepository
    {
        private int[] data = new int[10];

        public int this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public int getSize()
        {
            return data.Length;
        }
    }
}
