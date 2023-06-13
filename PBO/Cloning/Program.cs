using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GFG1 {
    public int val;
 
    public GFG1(int val){
        this.val = val;
    }
}
 
class GFG2 {
    public GFG1 gg;
    public GFG2(int val){
        // copy the reference of GFG1 to gg
        this.gg = new GFG1(val);  
    }
 
    // method for cloning
    public GFG2 Clone(){
        // return cloned value using
        // MemberwiseClone() method
        return ((GFG2)MemberwiseClone());
        
    }
}
 
// Driver Code
class Geek {

    // Main Method
    public static void Main(){
        // object of Class GFG2 with a value 3
        GFG2 g = new GFG2(3);
         
        // calling Clone()
        // "cc" has the reference of Clone()
        GFG2 cc = g.Clone();
        
        // accessing the main value
        Console.WriteLine("Value: " + g.gg.val);
         
        // accessing the cloned value
        Console.WriteLine("cloned value: " + cc.gg.val);
         
        // set a new value
        // in variable "val"
        cc.gg.val = 6;
         
        // accessing the main value
        Console.WriteLine("\nValue: " + g.gg.val);
        
        // accessing the cloned value
        Console.WriteLine("cloned value: " + cc.gg.val);
         
    }
}