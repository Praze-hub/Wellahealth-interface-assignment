using System;

namespace Assignment
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int a);
    }
        public class Car : IVehicle{
            public int Gas
            {get; set;}

            public Car(int gas)
            {
                Gas = gas;
                
            }
            public void Drive(){
                if(Gas > 0)
                {
                    Console.WriteLine("Car is driving");
                }else{
                    Console.WriteLine("There is no fuel");
                }
            }
            public bool Refuel(int a){
                Gas +=a;
                return true;
            }
        }
        public class Program{

       
        static void Main(string[] args)
        {
            Car benz = new Car(0);
            Console.WriteLine("How much of gas do you want:");
            int gas = int.Parse(Console.ReadLine());

            if(benz.Refuel(gas)){
                benz.Drive();
            }
        }
    }
}
 