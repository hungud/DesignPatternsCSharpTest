using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// as ConcreteFactory 
    /// lớp chế tạo sản phẩm cụ thể
    /// </summary>
    public class VinFastFactory : CarFactory
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
                case "luxa20": return new VinFastLUXA20();
                case "luxsa20": return new VinFastLUXSA20();
                case "fadil": return new VinFastFadil();
                default: throw new ArgumentException("Invalid model.", "model");
            }
        }
    }
}
