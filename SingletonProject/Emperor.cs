using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject
{
    /// <summary>
    /// 徐志强 
    /// 当对一个类应用 sealed 修饰符时，
    /// 此修饰符会阻止其他类从该类继承。 
    /// 在下面的示例中，类 B 从类 A 继承，但是任何类都不能从类 B 继承。 
    /// </summary>
    public sealed class Emperor
    {
        private    static   Emperor emperor =new Emperor(); //初始化一个皇帝
        private Emperor()
        {
            //世俗和道德约束你，目的就是不希望产生第二个皇帝
        }
        public static Emperor Instance
        {
            get
            {
                return emperor;

            }
           
        }
        //皇帝发话了
        public   void Say()
        {
            Console.WriteLine("我就是皇帝某某某....");
        }
    }
}
