using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutDepo.Interfaces
{
    public interface IDataGrid
    {
        Task<DataTable> GetData(string tableName);
        Task<DataTable> GetData(string tableName,int id);
    }
}
