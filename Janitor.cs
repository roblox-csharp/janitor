using Roblox;

namespace JanitorModule
{
    interface IDestroyable {
        void Destroy();
    }

    interface IDisconnectable {
        void Disconnect();
    }
    
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

        public IDisconnectable Add(IDisconnectable obj, string? methodName = null, I? index = default)
        {
            return default!;
        }

        public IDestroyable Add(IDestroyable obj, string? methodName = null, I? index = default)
        {
            return default!;
        }

        public Action Add(Action obj, string? methodName = null, I? index = default)
        {
            return default!;
        }

        public object Add(object obj, string? methodName = null, I? index = default)
        {
            return default!;
        }

        public object AddObject(Type obj, string? methodName = null, I? index = default)
        {
            return default;
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

        public object? Get(I index)
        {
            return default;
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
