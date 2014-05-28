namespace Benchmarks
{
    public interface IInsertOneRecord : IBenchmark, IInsertData { }
    public interface IInsert50Records : IBenchmark, IInsertData { }
    public interface IInsert100Records : IBenchmark, IInsertData { }
    public interface IInsert500Records : IBenchmark, IInsertData { }
    public interface IInsert1000Records : IBenchmark, IInsertData { }
    public interface IInsert10000Records : IBenchmark, IInsertData { }
    public interface IInsert100000Records : IBenchmark, IInsertData { }
    public interface IInsert1000000Records : IBenchmark, IInsertData { }
}