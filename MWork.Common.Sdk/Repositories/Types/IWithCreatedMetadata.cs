using System;

namespace MWork.Common.Sdk.Repositories.Types
{
    public interface IWithCreatedMetadata
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }
}