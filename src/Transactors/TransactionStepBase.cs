using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public interface ITransactionStep<TInput> where TInput : notnull
    {
        Result<Error> Execute(ref TInput input);
        Result<Error> Rollback(Result<Error> error);
    }

    public abstract class TransactionStepBase<TInput>(ITransactionStep<TInput>? next) : ITransactionStep<TInput> where TInput : notnull
    {
        public Result<Error> Execute(ref TInput input)
        {
            var result = ExecuteInternal(ref input);
            if(result && next is not null)
                return next.Execute(ref input);
            
            if(result && next is null)
                return result;

            return Rollback(result);
        }

        protected abstract Result<Error> ExecuteInternal(ref TInput input);
        public abstract Result<Error> Rollback(Result<Error> error);
    }
}
