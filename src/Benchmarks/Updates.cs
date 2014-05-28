namespace Benchmarks
{
    public interface IUpdateOneRecord : IBenchmark, IUpdateData { }
    public interface IUpdate50Records : IBenchmark, IUpdateData { }
    public interface IUpdate10Records : IBenchmark, IUpdateData { }
    public interface IUpdate500Records : IBenchmark, IUpdateData { }
    public interface IUpdate1000Records : IBenchmark, IUpdateData { }
    public interface IUpdate10000Records : IBenchmark, IUpdateData { }
    public interface IUpdate100000Records : IBenchmark, IUpdateData { }
    public interface IUpdate1000000Records : IBenchmark, IUpdateData { }
}