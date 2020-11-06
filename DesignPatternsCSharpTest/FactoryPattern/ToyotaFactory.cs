using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// as ConcreteFactory 
    /// lớp chế tạo sản phẩm cụ thể
    /// </summary>
    public class ToyotaFactory : CarFactory
    {
        /// <summary>
        /// ham tao san pham cu the
        /// </summary>
        /// <param name="carModel"></param>
        /// <returns></returns>
        public override Car CreateCar(string carModel)
        {
            switch (carModel.ToLower().Trim())
            {
                case "fortuner": return new ToyotaFortuner();
                case "rush": return new ToyotaRush();
                case "Yaris": return new ToyotaYaris();
                default: throw new ArgumentException("Invalid model.", "model");
            }
        }
    }
}
