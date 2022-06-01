using System;

namespace Corsework.Data.Models.CsModels.Components
{
    /// <summary>
    /// Оперативная память.
    /// </summary>
    [Serializable]
    public class RAM : Part
    {
        /// <summary>
        /// Размер оперативной памяти, Мб.
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Тип оперативной памяти.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Тактовая чатота.
        /// </summary>
        public int ClockSpeed { get; set; }
        /// <summary>
        /// Значение латентности.
        /// </summary>
        public int CasLatency { get; set; }
        /// <summary>
        /// Напряжение питания.
        /// </summary>
        public double Voltage { get; set; }

        public RAM()
        {

        }
    }
}
