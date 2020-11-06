using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// as FactoryBase
    /// lớp chế tạo sản phẩm cơ sở
    /// </summary>
    public abstract class CarFactory
    {
        /// <summary>
        /// Hàm chế tạo sản phẩm cơ sở
        /// </summary>
        /// <param name="model">dòng xe</param>
        /// <returns></returns>
        public abstract Car CreateCar(string carModel);
    }
}
