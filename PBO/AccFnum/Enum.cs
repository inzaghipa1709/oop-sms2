using System;

namespace AccFnum{
    public class Enum{
        public static void Main(string[] args){
            LevelType myNum = LevelType.High;
            
            switch (myNum)
            {
                case LevelType.Low:
                    Console.WriteLine("Low level");
                    break;
                case LevelType.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case LevelType.High:
                    Console.WriteLine("High level");
                    break;
            }
        }
    }
}