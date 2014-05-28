namespace Benchmarks
{
    public interface IDeleteOneRecord : IBenchmark, IDeleteData { }
    public interface IDelete10RecordsUsingPrimaryKey : IBenchmark, IDeleteData { }
    public interface IDelete10RecordsUsingColumn : IBenchmark, IDeleteData { }
}