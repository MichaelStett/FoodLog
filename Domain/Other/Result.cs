using FoodLog.Domain.Enums;

namespace FoodLog.Domain.Other
{
    public class Result<T>
    {
        Result(EOperationStatus status, T value)
            => (Status, Value) = (status, value);

        public EOperationStatus Status { get; }

        public T Value { get; }

        public static Result<T> Create(EOperationStatus status, T value)
        {
            return new Result<T>(status, value);
        }
    }
}
