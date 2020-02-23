using System;

namespace MWork.Common.Sdk.Repositories.Types
{
    public interface IWithModifiedMetadata
    {
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAtUtc { get; set; }
    }
}