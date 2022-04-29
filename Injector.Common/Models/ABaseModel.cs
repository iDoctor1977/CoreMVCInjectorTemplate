using System;
using Injector.Common.Interfaces.ICqrs;

namespace Injector.Common.Models
{
    public abstract class ABaseModel : ICqrsQueryBase, ICqrsCommandBase
    {
        public Guid Guid { get; set; }
        public PagingData PagingData { get; set; }
    }
}