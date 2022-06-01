using System;

namespace Corsework.Data.Models.CsModels
{
    [Serializable]
    public class Part
    {
        /// <summary>
        /// Id продукта.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Id категории продуктов.
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        /// Производитель продукта.
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Серия продукта.
        /// </summary>
        public string Series { get; set; }
        /// <summary>
        /// Модель продукта.
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Цена продукта.
        /// </summary>
        public double Cost { get; set; }

        public Part()
        {

        }
    }
}
