using System;

namespace Common.Base
{
    public abstract class DomainObjectBase
    {
        protected Guid? _UniqueId;


        public DomainObjectBase()
        {
            _UniqueId = Guid.NewGuid();
        }


        public Guid? UniqueId { get; set; }


    }
}
