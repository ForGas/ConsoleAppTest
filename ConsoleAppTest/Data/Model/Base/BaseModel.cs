using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Data.Model.Base
{
    public abstract class BaseModel : IEntity
    {
        public long Id { get; set; }
    }

}
