﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kurs4
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Экс файлы.
    /// </summary>
    // *** Start programmer edit section *** (ЭксФайлы CustomAttributes)

    // *** End programmer edit section *** (ЭксФайлы CustomAttributes)
    [AutoAltered()]
    [Caption("\"Эксель\" файлы")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЭксФайлыE", new string[] {
            "Дата as \'Дата\'",
            "Репозиторий as \'Репозиторий\'",
            "Имя as \'Имя\'",
            "Расширение as \'Расширение\'",
            "Расширение.Наименование as \'Наименование\'",
            "Размер as \'Размер\'",
            "ЕдиИзм as \'Единицы измерения\'",
            "ЕдиИзм.Наименование as \'Наименование\'"}, Hidden=new string[] {
            "Расширение.Наименование",
            "ЕдиИзм.Наименование"})]
    [MasterViewDefineAttribute("ЭксФайлыE", "Расширение", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [MasterViewDefineAttribute("ЭксФайлыE", "ЕдиИзм", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("ЭксФайлыL", new string[] {
            "Дата as \'Дата\'",
            "Репозиторий as \'Репозиторий\'",
            "Имя as \'Имя\'",
            "Расширение.Наименование as \'Расширение\'",
            "Размер as \'Размер\'",
            "ЕдиИзм.Наименование as \'Единицы измерения\'"})]
    public class ЭксФайлы : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private string fРепозиторий;
        
        private string fИмя;
        
        private int fРазмер;
        
        private IIS.Kurs4.Расширение fРасширение;
        
        private IIS.Kurs4.ЕдиИзм fЕдиИзм;
        
        // *** Start programmer edit section *** (ЭксФайлы CustomMembers)

        // *** End programmer edit section *** (ЭксФайлы CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ЭксФайлы.Дата CustomAttributes)

        // *** End programmer edit section *** (ЭксФайлы.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ЭксФайлы.Дата Get start)

                // *** End programmer edit section *** (ЭксФайлы.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ЭксФайлы.Дата Get end)

                // *** End programmer edit section *** (ЭксФайлы.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭксФайлы.Дата Set start)

                // *** End programmer edit section *** (ЭксФайлы.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ЭксФайлы.Дата Set end)

                // *** End programmer edit section *** (ЭксФайлы.Дата Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (ЭксФайлы.Имя CustomAttributes)

        // *** End programmer edit section *** (ЭксФайлы.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (ЭксФайлы.Имя Get start)

                // *** End programmer edit section *** (ЭксФайлы.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (ЭксФайлы.Имя Get end)

                // *** End programmer edit section *** (ЭксФайлы.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭксФайлы.Имя Set start)

                // *** End programmer edit section *** (ЭксФайлы.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (ЭксФайлы.Имя Set end)

                // *** End programmer edit section *** (ЭксФайлы.Имя Set end)
            }
        }
        
        /// <summary>
        /// Размер.
        /// </summary>
        // *** Start programmer edit section *** (ЭксФайлы.Размер CustomAttributes)

        // *** End programmer edit section *** (ЭксФайлы.Размер CustomAttributes)
        public virtual int Размер
        {
            get
            {
                // *** Start programmer edit section *** (ЭксФайлы.Размер Get start)

                // *** End programmer edit section *** (ЭксФайлы.Размер Get start)
                int result = this.fРазмер;
                // *** Start programmer edit section *** (ЭксФайлы.Размер Get end)

                // *** End programmer edit section *** (ЭксФайлы.Размер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭксФайлы.Размер Set start)

                // *** End programmer edit section *** (ЭксФайлы.Размер Set start)
                this.fРазмер = value;
                // *** Start programmer edit section *** (ЭксФайлы.Размер Set end)

                // *** End programmer edit section *** (ЭксФайлы.Размер Set end)
            }
        }
        
        /// <summary>
        /// Репозиторий.
        /// </summary>
        // *** Start programmer edit section *** (ЭксФайлы.Репозиторий CustomAttributes)

        // *** End programmer edit section *** (ЭксФайлы.Репозиторий CustomAttributes)
        [StrLen(255)]
        public virtual string Репозиторий
        {
            get
            {
                // *** Start programmer edit section *** (ЭксФайлы.Репозиторий Get start)

                // *** End programmer edit section *** (ЭксФайлы.Репозиторий Get start)
                string result = this.fРепозиторий;
                // *** Start programmer edit section *** (ЭксФайлы.Репозиторий Get end)

                // *** End programmer edit section *** (ЭксФайлы.Репозиторий Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭксФайлы.Репозиторий Set start)

                // *** End programmer edit section *** (ЭксФайлы.Репозиторий Set start)
                this.fРепозиторий = value;
                // *** Start programmer edit section *** (ЭксФайлы.Репозиторий Set end)

                // *** End programmer edit section *** (ЭксФайлы.Репозиторий Set end)
            }
        }
        
        /// <summary>
        /// Экс файлы.
        /// </summary>
        // *** Start programmer edit section *** (ЭксФайлы.ЕдиИзм CustomAttributes)

        // *** End programmer edit section *** (ЭксФайлы.ЕдиИзм CustomAttributes)
        [PropertyStorage(new string[] {
                "ЕдиИзм"})]
        [NotNull()]
        public virtual IIS.Kurs4.ЕдиИзм ЕдиИзм
        {
            get
            {
                // *** Start programmer edit section *** (ЭксФайлы.ЕдиИзм Get start)

                // *** End programmer edit section *** (ЭксФайлы.ЕдиИзм Get start)
                IIS.Kurs4.ЕдиИзм result = this.fЕдиИзм;
                // *** Start programmer edit section *** (ЭксФайлы.ЕдиИзм Get end)

                // *** End programmer edit section *** (ЭксФайлы.ЕдиИзм Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭксФайлы.ЕдиИзм Set start)

                // *** End programmer edit section *** (ЭксФайлы.ЕдиИзм Set start)
                this.fЕдиИзм = value;
                // *** Start programmer edit section *** (ЭксФайлы.ЕдиИзм Set end)

                // *** End programmer edit section *** (ЭксФайлы.ЕдиИзм Set end)
            }
        }
        
        /// <summary>
        /// Экс файлы.
        /// </summary>
        // *** Start programmer edit section *** (ЭксФайлы.Расширение CustomAttributes)

        // *** End programmer edit section *** (ЭксФайлы.Расширение CustomAttributes)
        [PropertyStorage(new string[] {
                "Расширение"})]
        [NotNull()]
        public virtual IIS.Kurs4.Расширение Расширение
        {
            get
            {
                // *** Start programmer edit section *** (ЭксФайлы.Расширение Get start)

                // *** End programmer edit section *** (ЭксФайлы.Расширение Get start)
                IIS.Kurs4.Расширение result = this.fРасширение;
                // *** Start programmer edit section *** (ЭксФайлы.Расширение Get end)

                // *** End programmer edit section *** (ЭксФайлы.Расширение Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭксФайлы.Расширение Set start)

                // *** End programmer edit section *** (ЭксФайлы.Расширение Set start)
                this.fРасширение = value;
                // *** Start programmer edit section *** (ЭксФайлы.Расширение Set end)

                // *** End programmer edit section *** (ЭксФайлы.Расширение Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЭксФайлыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЭксФайлыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЭксФайлыE", typeof(IIS.Kurs4.ЭксФайлы));
                }
            }
            
            /// <summary>
            /// "ЭксФайлыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЭксФайлыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЭксФайлыL", typeof(IIS.Kurs4.ЭксФайлы));
                }
            }
        }
    }
}
