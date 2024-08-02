using Roblox;

namespace JanitorModule
{
    public class Janitor : Janitor<string>
    { 
    }

    public class Janitor<I> where I : notnull
    {
        public bool CurrentlyCleaning { get; }
        public bool SuppressInstanceReDestroy { get; set; }

        public static bool Is(object obj)
        {
            return default;
        }

        public T Add<T>(T obj, string? methodName = null, I? index = default) where T : notnull
        {
            return default!;
        }

        public T AddObject<T>(Type obj, string? methodName = null, I? index = default) where T : notnull
        {
            return default!;
        }

        public Janitor Remove(I index)
        {
            return null!;
        }

        public Janitor RemoveNoClean(I index)
        {
            return null!;
        }

        public Janitor RemoveList(params I[] indices)
        {
            return null!;
        }

        public Janitor RemoveListNoClean(params I[] indices)
        {
            return null!;
        }

        public T? Get<T>(I index) where T : notnull
        {
            return default;
        }

        public IDictionary<I, T> GetAll<T>() where T : notnull
        {
            return null!;
        }

        public void Cleanup()
        { 
        }

        public void Destroy()
        {
        }

        public ScriptConnection LinkToInstance(Instance instance, bool allowMultiple)
        {
            return null!;
        }

        public Janitor LinkToInstances(params Instance[] instances)
        {
            return null!;
        }
    }
}