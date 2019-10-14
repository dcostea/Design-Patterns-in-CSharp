﻿using AbstractFactorySample.Product;
using System;

namespace AbstractFactorySample.Factory
{
    /// <summary>
    /// Concrete factory class
    /// </summary>
    class Autoland : IDealer
    {
        public ITyre GetTyre(string category)
        {
            switch (category)
            {
                case "Sports":
                    return new Michelin();

                case "Regular":
                    return new Dunlop();

                default:
                    throw new ApplicationException($"Tyre '{category}' cannot be created");
            }
        }

        public ICar GetCar(string category)
        {
            switch (category)
            {
                case "Sports":
                    return new Ferrari();

                case "Regular":
                    return new Skoda();

                default:
                    throw new ApplicationException($"Tyre '{category}' cannot be created");
            }
        }
    }
}
