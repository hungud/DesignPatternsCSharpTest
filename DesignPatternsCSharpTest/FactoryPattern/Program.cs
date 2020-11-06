using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hệ thống tự động chọn ra đúng lớp tùy thuộc vào model nhập vào");

            CarFactory carFacVin = new VinFastFactory();
            Car carVin = carFacVin.CreateCar(carModel: "LUXA20");
            Console.WriteLine("Hệ thống tạo VinFast LUXA20 => " + carVin.GetType());

            CarFactory carFacToy = new ToyotaFactory();
            Car carTyo = carFacToy.CreateCar(carModel: "Fortuner");
            Console.WriteLine("Hệ thống tạo Toyota Fortuner => " + carTyo.GetType());

            Console.ReadLine();
        }
    }
}
