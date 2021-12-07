using Injector.Common.Enums;

namespace Injector.Common
{
    public class OperationResult<T>
    {
        public OperationResult() { }

        public T Object { get; set; }
        public OperationsStatus Status { get; set; }
        public string Message { get; set; }
    }
}
