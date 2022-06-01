using System;

namespace Corsework.Data.Models.CsModels.Components
{

    /// <summary>
    /// Видео карта.
    /// </summary>
    [Serializable]
    public class VideoCard : Part
    {
        #region Chipset
        /// <summary>
        /// Производитель чипсета.
        /// </summary>
        public string ChipsetManufacturer { get; set; }
        /// <summary>
        /// Графический процессор.
        /// </summary>
        public string GPU { get; set; }
        /// <summary>
        /// Тактовая частота процессора, MHz.
        /// </summary>
        public int CoreClock { get; set; }
        #endregion //End Chipset

        #region Memory
        /// <summary>
        /// Размер памяти, Мб.
        /// </summary>
        public int MemorySize { get; set; }
        /// <summary>
        /// Физический интерфейс памяти, бит.
        /// </summary>
        public int MemoryInterface { get; set; }
        /// <summary>
        /// Тип памяти.
        /// </summary>
        public string MemoryType { get; set; }
        #endregion //End Memory

        #region 3D API
        /// <summary>
        /// Поддерка версии DirecX.
        /// </summary>
        public string DirectX { get; set; }
        /// <summary>
        /// Поддержка OpenGL.
        /// </summary>
        public string OpenGL { get; set; }
        #endregion //End 3D API

        public VideoCard()
        {

        }
    }
}
