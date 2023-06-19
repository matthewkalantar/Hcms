using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcms.Common.Attributes
{
    public class DBFieldNameAttribute : Attribute
    {
        private string name;

        public DBFieldNameAttribute(string name)
        {
            this.name = name;
        }
        public virtual string Name
        {
            get { return name; }
        }
    }
}
