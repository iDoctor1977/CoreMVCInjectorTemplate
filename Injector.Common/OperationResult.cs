using Injector.Common.Enums;

namespace Injector.Common
{
    public class OperationResult<T>
    {
        private T _value;

        public OperationResult() { }

        public OperationResult(T value) {
            _value = value;
        }

        public T Value {
            get { return _value; }
            set { _value = value; }
        }

        public OperationsStatus Status { get; set; }
        public string Message { get; set; }
    }
}
