namespace csharp_examples.Interfaces
{
  public class DoerImplementation
  {
    private readonly IDoer _idoer;
    public DoerImplementation(IDoer idoer)
    {
      this._idoer = idoer;
    }

    public void MakeItHappen()
    {
        _idoer.GetDoerId();
    }
  }
}