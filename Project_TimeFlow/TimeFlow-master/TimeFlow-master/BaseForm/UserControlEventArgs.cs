using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseForm
{
    public class UserControlEventArgs : EventArgs
    {
        public string Identifier { get; set; }

        public UserControlEventArgs(string identifier)
        {
            Identifier = identifier;
        }
    }
}
