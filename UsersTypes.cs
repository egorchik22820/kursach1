using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    internal class UsersTypes
    {
        private int _typeID;
        private string _typeName;
        public int TypeID { get => _typeID; }
        public string TypeName { get => _typeName; }
        public UsersTypes(string typeName, int typeID)
        {
            _typeName = typeName;
            _typeID = typeID;
            
        }

        public override string ToString()
        {
            return _typeName;
        }

    }
}
