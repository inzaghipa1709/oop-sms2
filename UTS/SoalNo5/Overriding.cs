using System;

// Overriding Methods in C#

namespace SoalNo5
{
    class baseClass {
        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    // class 'baseClass' inherit
    // class 'derived'
    class derived : baseClass
    {
        //'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Overriding {
        
        // Main Method
        public static void Main(string[] args)
        {
            baseClass obj;
    
            // 'obj' is the object
            // Of class 'baseClass'
            obj = new baseClass();
            
            // It invokes 'show()'
            // of class 'baseClass'
            obj.show();
            
            // The same object 'obj' is now
            // The object of class 'derived'
            obj = new derived();
            
            // It invokes 'show()' of class 'derived'
            // 'show()' of class 'derived' is overridden
            // For 'override' modifier
            obj.show();
        }
    }
}