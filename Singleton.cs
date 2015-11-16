public sealed class Singleton
{
    private static Singleton _singleton;
    private static object syncObject = new object();

    public int Age { get; set; }

    // private constructor
    private Singleton()
    {
        
    }

    public static Singleton CreateInstance()
    {
        lock (syncObject)
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
        }
        
        return _singleton;
    }

}
