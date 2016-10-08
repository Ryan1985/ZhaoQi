using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ZhaoQi.DAL
{
    public interface IDal
    {
        DataTable Query(Hashtable filterList);
        string Insert(Hashtable htData);
        string Update(Hashtable htData, Hashtable filterList);
        string Delete(Hashtable filterList);
    }
}
