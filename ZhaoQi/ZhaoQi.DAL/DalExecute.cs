using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ZhaoQi.DAL
{
    public class DalExecute:IDal
    {
        public string Insert(Hashtable htData)
        {
            return string.Empty;
        }

        public DataTable Query(Hashtable filterList)
        {
            throw new NotImplementedException();
        }

        public string Update(Hashtable htData, Hashtable filterList)
        {
            throw new NotImplementedException();
        }

        public string Delete(Hashtable filterList)
        {
            throw new NotImplementedException();
        }
    }
}
