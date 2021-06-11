using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { }
        public int Id { get; private set; }
    }
}
