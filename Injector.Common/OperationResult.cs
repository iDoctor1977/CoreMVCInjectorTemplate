using Injector.Common.Enums;

namespace Injector.Common
{
    public class OperationResult<T>
    {
        public OperationResult() { }

        public T Value { get; set; }
        public OperationsStatus Status { get; set; }
        public string Message { get; set; }
    }
}
