using System;
using System.Collections.Generic;

namespace Corsework.Data.Models.CsModels.Components
{
    /// <summary>
    /// Процессор.
    /// </summary>
    [Serializable]
    public class Processor : Part
    {
        /// <summary>
        /// Сокет.
        /// </summary>
        public string Socket { get; set; }

        /// <summary>
        /// Название процессора.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Коичество ядер в процессоре.
        /// </summary>
        public int NumberOfCores { get; set; }
        /// <summary>
        /// Тактовая частота, MHz.
        /// </summary>
        public int ClockSpeed { get; set; }
        /// <summary>
        /// Размер кэша первого уровня, KB.
        /// </summary>
        public int CacheLevel1 { get; set; }
        /// <summary>
        /// Размер кэша второго уровня, KB.
        /// </summary>
        public int CacheLevel2 { get; set; }
        /// <summary>
        /// Размер кэша третьего уровня, KB.
        /// </summary>
        public int CacheLevel3 { get; set; }
        /// <summary>
        /// Поддерживаемые технологии.
        /// </summary>
        public List<string> AdvancedTechnologies { get; set; }

        /// <summary>
        /// Размер кристалла, мм.
        /// </summary>
        public int ManufacturingTech { get; set; }
        /// <summary>
        /// Максимальное энергопотребление, Вт.
        /// </summary>
        public int MaxTDP { get; set; }
        /// <summary>
        /// Система охлаждения.
        /// </summary>
        public string CoolingDevice { get; set; }

        public Processor()
        {

        }
    }
}
