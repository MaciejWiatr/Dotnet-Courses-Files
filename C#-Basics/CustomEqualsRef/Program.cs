using System;

namespace CustomEqualsRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int horsePower1 = 350;
            int horsePower2 = 350;

            bool valueTypeEqual = horsePower1 == horsePower2;

            Car car1 = new Car(horsePower1);
            Car car2 = new Car(horsePower2);

            bool reftTypeEqual = car1 == car2;

            Console.WriteLine(valueTypeEqual);
            Console.WriteLine(reftTypeEqual);
        }
    }

    class Car
    {
        public int horsePower;

        public static bool operator ==(Car left, Car right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            Car carObj = (Car)obj;
            return this.horsePower == carObj.horsePower;
        }


        public Car(int horsepower)
        {
            horsePower = horsepower;
        }
    }
}
