using System.Collections.Generic;
using TaskEFConsoleApp.Data.Model.Base;

namespace TaskEFConsoleApp.Interfaces
{
    public interface IDisplay
    {
        public void Print<T>(ICollection<T> entities) where T : IEntity;
    }
}
