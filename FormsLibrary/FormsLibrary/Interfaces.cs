using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary
{
    interface IPerson
    {
        string _name { get; set; }
        string _surname { get; set; }
    }
    interface IBook
    {
        string _name { get; set; }
        string _author { get; set; }
        int _ProductionYear { get; set; }
        string _Genre { get; set; }
    }
    /*interface ICompareble
     {
        int CompareTo();
    }
     */
}
