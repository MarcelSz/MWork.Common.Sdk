using System;

namespace MWork.Common.Sdk.Repositories.Types
{
    public interface IWithId
    {
        public Guid Id { get; set; }
    }
}