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
    /// Тч_настр.
    /// </summary>
    // *** Start programmer edit section *** (Тч_настр CustomAttributes)

    // *** End programmer edit section *** (Тч_настр CustomAttributes)
    [AutoAltered()]
    [Caption("Атрибуты настройки")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Тч_настрE", new string[] {
            "Атрибут as \'Атрибут\'",
            "ТипАтр as \'Тип атр\'",
            "Ограничение as \'Ограничение\'",
            "Обязательное as \'Обязательное\'"})]
    public class Тч_настр : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.Kurs4.ТипАтр fТипАтр;
        
        private string fАтрибут;
        
        private int fОграничение;
        
        private bool fОбязательное;
        
        private IIS.Kurs4.НастрКонв fНастрКонв;
        
        // *** Start programmer edit section *** (Тч_настр CustomMembers)

        // *** End programmer edit section *** (Тч_настр CustomMembers)

        
        /// <summary>
        /// Атрибут.
        /// </summary>
        // *** Start programmer edit section *** (Тч_настр.Атрибут CustomAttributes)

        // *** End programmer edit section *** (Тч_настр.Атрибут CustomAttributes)
        [StrLen(255)]
        public virtual string Атрибут
        {
            get
            {
                // *** Start programmer edit section *** (Тч_настр.Атрибут Get start)

                // *** End programmer edit section *** (Тч_настр.Атрибут Get start)
                string result = this.fАтрибут;
                // *** Start programmer edit section *** (Тч_настр.Атрибут Get end)

                // *** End programmer edit section *** (Тч_настр.Атрибут Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Тч_настр.Атрибут Set start)

                // *** End programmer edit section *** (Тч_настр.Атрибут Set start)
                this.fАтрибут = value;
                // *** Start programmer edit section *** (Тч_настр.Атрибут Set end)

                // *** End programmer edit section *** (Тч_настр.Атрибут Set end)
            }
        }
        
        /// <summary>
        /// Обязательное.
        /// </summary>
        // *** Start programmer edit section *** (Тч_настр.Обязательное CustomAttributes)

        // *** End programmer edit section *** (Тч_настр.Обязательное CustomAttributes)
        public virtual bool Обязательное
        {
            get
            {
                // *** Start programmer edit section *** (Тч_настр.Обязательное Get start)

                // *** End programmer edit section *** (Тч_настр.Обязательное Get start)
                bool result = this.fОбязательное;
                // *** Start programmer edit section *** (Тч_настр.Обязательное Get end)

                // *** End programmer edit section *** (Тч_настр.Обязательное Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Тч_настр.Обязательное Set start)

                // *** End programmer edit section *** (Тч_настр.Обязательное Set start)
                this.fОбязательное = value;
                // *** Start programmer edit section *** (Тч_настр.Обязательное Set end)

                // *** End programmer edit section *** (Тч_настр.Обязательное Set end)
            }
        }
        
        /// <summary>
        /// Ограничение.
        /// </summary>
        // *** Start programmer edit section *** (Тч_настр.Ограничение CustomAttributes)

        // *** End programmer edit section *** (Тч_настр.Ограничение CustomAttributes)
        public virtual int Ограничение
        {
            get
            {
                // *** Start programmer edit section *** (Тч_настр.Ограничение Get start)

                // *** End programmer edit section *** (Тч_настр.Ограничение Get start)
                int result = this.fОграничение;
                // *** Start programmer edit section *** (Тч_настр.Ограничение Get end)

                // *** End programmer edit section *** (Тч_настр.Ограничение Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Тч_настр.Ограничение Set start)

                // *** End programmer edit section *** (Тч_настр.Ограничение Set start)
                this.fОграничение = value;
                // *** Start programmer edit section *** (Тч_настр.Ограничение Set end)

                // *** End programmer edit section *** (Тч_настр.Ограничение Set end)
            }
        }
        
        /// <summary>
        /// ТипАтр.
        /// </summary>
        // *** Start programmer edit section *** (Тч_настр.ТипАтр CustomAttributes)

        // *** End programmer edit section *** (Тч_настр.ТипАтр CustomAttributes)
        public virtual IIS.Kurs4.ТипАтр ТипАтр
        {
            get
            {
                // *** Start programmer edit section *** (Тч_настр.ТипАтр Get start)

                // *** End programmer edit section *** (Тч_настр.ТипАтр Get start)
                IIS.Kurs4.ТипАтр result = this.fТипАтр;
                // *** Start programmer edit section *** (Тч_настр.ТипАтр Get end)

                // *** End programmer edit section *** (Тч_настр.ТипАтр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Тч_настр.ТипАтр Set start)

                // *** End programmer edit section *** (Тч_настр.ТипАтр Set start)
                this.fТипАтр = value;
                // *** Start programmer edit section *** (Тч_настр.ТипАтр Set end)

                // *** End programmer edit section *** (Тч_настр.ТипАтр Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Kurs4.НастрКонв.
        /// </summary>
        // *** Start programmer edit section *** (Тч_настр.НастрКонв CustomAttributes)

        // *** End programmer edit section *** (Тч_настр.НастрКонв CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "НастрКонв"})]
        public virtual IIS.Kurs4.НастрКонв НастрКонв
        {
            get
            {
                // *** Start programmer edit section *** (Тч_настр.НастрКонв Get start)

                // *** End programmer edit section *** (Тч_настр.НастрКонв Get start)
                IIS.Kurs4.НастрКонв result = this.fНастрКонв;
                // *** Start programmer edit section *** (Тч_настр.НастрКонв Get end)

                // *** End programmer edit section *** (Тч_настр.НастрКонв Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Тч_настр.НастрКонв Set start)

                // *** End programmer edit section *** (Тч_настр.НастрКонв Set start)
                this.fНастрКонв = value;
                // *** Start programmer edit section *** (Тч_настр.НастрКонв Set end)

                // *** End programmer edit section *** (Тч_настр.НастрКонв Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Тч_настрE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Тч_настрE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Тч_настрE", typeof(IIS.Kurs4.Тч_настр));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Тч_настр.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfТч_настр CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfТч_настр CustomAttributes)
    public class DetailArrayOfТч_настр : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Kurs4.DetailArrayOfТч_настр members)

        // *** End programmer edit section *** (IIS.Kurs4.DetailArrayOfТч_настр members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Тч_настр by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Тч_настр.
        /// </summary>
        public DetailArrayOfТч_настр(IIS.Kurs4.НастрКонв fНастрКонв) : 
                base(typeof(Тч_настр), ((ICSSoft.STORMNET.DataObject)(fНастрКонв)))
        {
        }
        
        public IIS.Kurs4.Тч_настр this[int index]
        {
            get
            {
                return ((IIS.Kurs4.Тч_настр)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Kurs4.Тч_настр dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
