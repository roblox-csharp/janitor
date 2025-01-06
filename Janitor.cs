using Roblox;

namespace JanitorModule
{
    public interface IDestroyable {
        void Destroy();
    }

    public interface IDisconnectable {
        void Disconnect();
    }
    
    public class Janitor : Janitor<string>
    { 
    }

    public class Janitor<I> where I : notnull
    {
        public bool CurrentlyCleaning { get; }
        public bool SuppressInstanceReDestroy { get; set; }

        public static extern bool Is(object obj);

        public extern IDisconnectable Add(IDisconnectable obj, string? methodName = null, I? index = default);
        public extern IDestroyable Add(IDestroyable obj, string? methodName = null, I? index = default);
        public extern Action Add(Action obj, string? methodName = null, I? index = default);
        public extern object Add(object obj, string? methodName = null, I? index = default);
        public extern object AddObject(Type obj, string? methodName = null, I? index = default);
        public extern T AddObject<T>(Type obj, string? methodName = null, I? index = default) where T : notnull;
        public extern Janitor Remove(I index);
        public extern Janitor RemoveNoClean(I index);
        public extern Janitor RemoveList(params I[] indices);
        public extern Janitor RemoveListNoClean(params I[] indices);
        public extern object? Get(I index);
        public extern T? Get<T>(I index) where T : notnull;
        public extern IDictionary<I, T> GetAll<T>() where T : notnull;
        public extern void Cleanup();
        public extern void Destroy();
        public extern ScriptConnection LinkToInstance(Instance instance, bool allowMultiple);
        public extern Janitor LinkToInstances(params Instance[] instances);
    }
}
