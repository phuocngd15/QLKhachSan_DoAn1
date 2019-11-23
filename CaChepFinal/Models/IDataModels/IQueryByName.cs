using CaChepFinal.Models.DataModels;
using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Models.IDataModels
{
    public interface IQueryByName<T>
    {
        IQueryable<T> SearchByName(string str);
    
    }
}