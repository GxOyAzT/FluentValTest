namespace FluentValTest.Services;

public interface IService
{
    List<int> Get();
}


public sealed class Service : IService
{
    public List<int> Get()
    {
        return new List<int>() { 1,2,3,4,5 };
    }
}