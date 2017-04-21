using System.Collections.Generic;

namespace Parser.WPF.DataAccess.Interfaces
{
    public interface IDataAccess<T>
    {
        ICollection<T> Get();
    }
}