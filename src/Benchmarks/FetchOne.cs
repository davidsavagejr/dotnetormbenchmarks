namespace Benchmarks
{
    public interface IFetchOneFromPkUsingSql : IBenchmark, IQueryData { }
    public interface IFetchOneFromPkUsingLinq : IBenchmark, IQueryData { }

    public interface IFetchOneFromOneToManyUsingSql : IBenchmark, IQueryData { }
    public interface IFetchOneFromOneToManyUsingLinq : IBenchmark, IQueryData { }
}