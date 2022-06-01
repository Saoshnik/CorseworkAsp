using System;
using System.Collections.Generic;

namespace Corsework.Data.Models.CsModels.Components
{
    /// <summary>
    /// Материнская плата.
    /// </summary>
    [Serializable]
    public class Motherboard : Part
    {
        #region Supported CPU
        /// <summary>
        /// Сокет.
        /// </summary>
        public string CPUSocket { get; set; }
        /// <summary>
        /// Список поддерживаемых процессоров.
        /// </summary>
        public List<string> CPUType { get; set; }
        #endregion //end Supported CPU

        #region Memory
        /// <summary>
        /// Тип оперативной памяти.
        /// </summary>
        public string MemoryType { get; set; }
        /// <summary>
        /// Минимальная частота оперативной памяти.
        /// </summary>
        public int MemoryMinFrequency { get; set; }
        /// <summary>
        /// Максимальная частота оперативной памяти.
        /// </summary>
        public int MemoryMaxFrequence { get; set; }
        /// <summary>
        /// Количество слотов памяти.
        /// </summary>
        public int MemoryNumberOfSlots { get; set; }
        /// <summary>
        /// Максимальный объем поддерживаемой памяти.
        /// </summary>
        public int MemoryMaxSize { get; set; }
        #endregion //end Memory

        public Motherboard()
        {

        }
    }
}
