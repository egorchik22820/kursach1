using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    internal class Resources
    {
        private int _resourceID;
        private string _resourceName;
        public int ResourceID { get => _resourceID; }
        public string ResourceName { get => _resourceName; }
        public Resources(string resourceName, int resourceID)
        {
            _resourceName = resourceName;
            _resourceID = resourceID;

        }

        public override string ToString()
        {
            return _resourceName;
        }
    }
}
