namespace Benchmarks
{
    public interface IFetchOneFromPkUsingSql : IBenchmark { }
    public interface IFetchOneFromPkUsingLinq : IBenchmark { }

    public interface IFetchOneFromOneToManyUsingSql : IBenchmark { }
    public interface IFetchOneFromOneToManyUsingLinq : IBenchmark { }
}