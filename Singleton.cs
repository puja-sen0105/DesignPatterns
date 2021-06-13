using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Singleton
    {
    }

    public sealed class SingletonPatternWithoutThreadSafety
    {
        private SingletonPatternWithoutThreadSafety() { }
        private static SingletonPatternWithoutThreadSafety _instance = null;
        
        public static SingletonPatternWithoutThreadSafety Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonPatternWithoutThreadSafety();
                }

                return _instance;
            }
        }
    }

    public sealed class SingletonPatternDoubleLock
    {
        private SingletonPatternDoubleLock() { }
        private static SingletonPatternDoubleLock _instance = null;
        private static readonly object obj = new object();

        public static SingletonPatternDoubleLock Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (obj)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonPatternDoubleLock();
                        }
                    }
                }
             
                return _instance;
            }
        }
    }

    public sealed class SingletonPatternStatic
    {
        private SingletonPatternStatic() { }
        static SingletonPatternStatic() { }
        private static readonly SingletonPatternStatic _instance = new SingletonPatternStatic();

        public static SingletonPatternStatic Instance
        {
            get
            {
                return _instance;
            }
        }
    }

    public sealed class SingletonPatternLazy
    {
        private SingletonPatternLazy() { }
        private static readonly Lazy<SingletonPatternLazy> _instance = new Lazy<SingletonPatternLazy>(()=> new SingletonPatternLazy());

        public static SingletonPatternLazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
