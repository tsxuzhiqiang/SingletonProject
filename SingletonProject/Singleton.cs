using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject
{
    /// <summary>
    /// 完全延迟实例化 的单例模式
    /// 
    /// 
    /// 关于本项目的博客地址：
    /// http://blog.csdn.net/bj_xuzhiqiang/article/details/70300021
    /// </summary>
    public sealed class Singleton
    {
        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}
