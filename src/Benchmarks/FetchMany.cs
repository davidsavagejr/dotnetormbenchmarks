namespace Benchmarks
{
    public interface IFetchTop50UsingSql : IBenchmark { }
    public interface IFetchTop100UsingSql : IBenchmark { }
    public interface IFetchTop500UsingSql : IBenchmark { }
    public interface IFetchTop1000UsingSql : IBenchmark { }
    public interface IFetchTop10000UsingSql : IBenchmark { }
    public interface IFetchTop100000UsingSql : IBenchmark { }

    public interface IFetchTop50UsingLinq : IBenchmark { }
    public interface IFetchTop100UsingLinq : IBenchmark { }
    public interface IFetchTop500UsingLinq : IBenchmark { }
    public interface IFetchTop1000UsingLinq : IBenchmark { }
    public interface IFetchTop10000UsingLinq : IBenchmark { }
    public interface IFetchTop100000UsingLinq : IBenchmark { }

    public interface IFetchTop50FromOneToManyUsingSql : IBenchmark { }
    public interface IFetchTop100FromOneToManyUsingSql : IBenchmark { }
    public interface IFetchTop500FromOneToManyUsingSql : IBenchmark { }
    public interface IFetchTop1000FromOneToManyUsingSql : IBenchmark { }
    public interface IFetchTop10000FromOneToManyUsingSql : IBenchmark { }
    public interface IFetchTop100000FromOneToManyUsingSql : IBenchmark { }

    public interface IFetchTop50FromOneToManyUsingLinq : IBenchmark { }
    public interface IFetchTop100FromOneToManyUsingLinq : IBenchmark { }
    public interface IFetchTop500FromOneToManyUsingLinq : IBenchmark { }
    public interface IFetchTop1000FromOneToManyUsingLinq : IBenchmark { }
    public interface IFetchTop10000FromOneToManyUsingLinq : IBenchmark { }
    public interface IFetchTop100000FromOneToManyUsingLinq : IBenchmark { }
}