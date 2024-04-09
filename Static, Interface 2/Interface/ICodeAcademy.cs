using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Static__Interface_2.Interface
{
    internal interface ICodeAcademy
    {
       
        string CodeEmail { get; set; }

        public void GenerateEmail();
    }
}
