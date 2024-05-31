namespace ConsoleApp3;

public class Poop
{
    private List<object> _objects = new List<object>();

    public void AddObjectToPoop(object item)
    {
        _objects.Add(item);
    }

    public void ClearPoop()
    {
        _objects = new List<object>();
    }
}