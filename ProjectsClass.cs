using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    internal class ProjectsClass
    {
        private int _projID;
        private string _projName;

        public int ProjID { get => _projID; }
        public string ProjName { get => _projName; }
        public ProjectsClass(string projName, int projID)
        {
            _projName = projName;
            _projID = projID;
        }

        public override string ToString()
        {
            return _projName;
        }
    }
}
