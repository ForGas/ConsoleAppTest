using ConsoleAppTest.Data.Model;
using ConsoleAppTest.Data.Model.Base;
using System.Collections.Generic;

namespace ConsoleAppTest.Interfaces
{
    public interface IDisplay
    {
        public void Print<T>(ICollection<T> entities) where T : IEntity;
    }
}
