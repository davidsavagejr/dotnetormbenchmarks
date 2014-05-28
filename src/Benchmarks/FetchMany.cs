namespace Benchmarks
{
    public interface IFetchTop50UsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop100UsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop500UsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop1000UsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop10000UsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop100000UsingSql : IBenchmark, IQueryData { }

    public interface IFetchTop50UsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop100UsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop500UsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop1000UsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop10000UsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop100000UsingLinq : IBenchmark, IQueryData { }

    public interface IFetchTop50FromOneToManyUsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop100FromOneToManyUsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop500FromOneToManyUsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop1000FromOneToManyUsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop10000FromOneToManyUsingSql : IBenchmark, IQueryData { }
    public interface IFetchTop100000FromOneToManyUsingSql : IBenchmark, IQueryData { }

    public interface IFetchTop50FromOneToManyUsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop100FromOneToManyUsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop500FromOneToManyUsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop1000FromOneToManyUsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop10000FromOneToManyUsingLinq : IBenchmark, IQueryData { }
    public interface IFetchTop100000FromOneToManyUsingLinq : IBenchmark, IQueryData { }
}