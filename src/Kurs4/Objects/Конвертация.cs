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
    /// Конвертация.
    /// </summary>
    // *** Start programmer edit section *** (Конвертация CustomAttributes)

    // *** End programmer edit section *** (Конвертация CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КонвертацияE", new string[] {
            "ИмяДок as \'Имя док\'",
            "ЗагрФайла as \'Загрузка файла\'",
            "ЗагрФайла.Путь as \'Путь\'",
            "НастрКонв as \'Настройки конвертации\'",
            "НастрКонв.Наименование as \'Наименование\'"}, Hidden=new string[] {
            "ЗагрФайла.Путь",
            "НастрКонв.Наименование"})]
    [MasterViewDefineAttribute("КонвертацияE", "ЗагрФайла", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Путь")]
    [MasterViewDefineAttribute("КонвертацияE", "НастрКонв", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("КонвертацияL", new string[] {
            "ИмяДок as \'Имя док\'",
            "ЗагрФайла.Путь as \'Загрузка файла\'",
            "НастрКонв.Наименование as \'Настройка\'"})]
    public class Конвертация : ICSSoft.STORMNET.DataObject
    {
        
        private string fИмяДок;
        
        private IIS.Kurs4.ЗагрФайла fЗагрФайла;
        
        private IIS.Kurs4.НастрКонв fНастрКонв;
        
        // *** Start programmer edit section *** (Конвертация CustomMembers)

        // *** End programmer edit section *** (Конвертация CustomMembers)

        
        /// <summary>
        /// ИмяДок.
        /// </summary>
        // *** Start programmer edit section *** (Конвертация.ИмяДок CustomAttributes)

        // *** End programmer edit section *** (Конвертация.ИмяДок CustomAttributes)
        [StrLen(255)]
        public virtual string ИмяДок
        {
            get
            {
                // *** Start programmer edit section *** (Конвертация.ИмяДок Get start)

                // *** End programmer edit section *** (Конвертация.ИмяДок Get start)
                string result = this.fИмяДок;
                // *** Start programmer edit section *** (Конвертация.ИмяДок Get end)

                // *** End programmer edit section *** (Конвертация.ИмяДок Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Конвертация.ИмяДок Set start)

                // *** End programmer edit section *** (Конвертация.ИмяДок Set start)
                this.fИмяДок = value;
                // *** Start programmer edit section *** (Конвертация.ИмяДок Set end)

                // *** End programmer edit section *** (Конвертация.ИмяДок Set end)
            }
        }
        
        /// <summary>
        /// Конвертация.
        /// </summary>
        // *** Start programmer edit section *** (Конвертация.ЗагрФайла CustomAttributes)

        // *** End programmer edit section *** (Конвертация.ЗагрФайла CustomAttributes)
        [PropertyStorage(new string[] {
                "ЗагрФайла"})]
        [NotNull()]
        public virtual IIS.Kurs4.ЗагрФайла ЗагрФайла
        {
            get
            {
                // *** Start programmer edit section *** (Конвертация.ЗагрФайла Get start)

                // *** End programmer edit section *** (Конвертация.ЗагрФайла Get start)
                IIS.Kurs4.ЗагрФайла result = this.fЗагрФайла;
                // *** Start programmer edit section *** (Конвертация.ЗагрФайла Get end)

                // *** End programmer edit section *** (Конвертация.ЗагрФайла Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Конвертация.ЗагрФайла Set start)

                // *** End programmer edit section *** (Конвертация.ЗагрФайла Set start)
                this.fЗагрФайла = value;
                // *** Start programmer edit section *** (Конвертация.ЗагрФайла Set end)

                // *** End programmer edit section *** (Конвертация.ЗагрФайла Set end)
            }
        }
        
        /// <summary>
        /// Конвертация.
        /// </summary>
        // *** Start programmer edit section *** (Конвертация.НастрКонв CustomAttributes)

        // *** End programmer edit section *** (Конвертация.НастрКонв CustomAttributes)
        [PropertyStorage(new string[] {
                "НастрКонв"})]
        [NotNull()]
        public virtual IIS.Kurs4.НастрКонв НастрКонв
        {
            get
            {
                // *** Start programmer edit section *** (Конвертация.НастрКонв Get start)

                // *** End programmer edit section *** (Конвертация.НастрКонв Get start)
                IIS.Kurs4.НастрКонв result = this.fНастрКонв;
                // *** Start programmer edit section *** (Конвертация.НастрКонв Get end)

                // *** End programmer edit section *** (Конвертация.НастрКонв Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Конвертация.НастрКонв Set start)

                // *** End programmer edit section *** (Конвертация.НастрКонв Set start)
                this.fНастрКонв = value;
                // *** Start programmer edit section *** (Конвертация.НастрКонв Set end)

                // *** End programmer edit section *** (Конвертация.НастрКонв Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КонвертацияE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонвертацияE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонвертацияE", typeof(IIS.Kurs4.Конвертация));
                }
            }
            
            /// <summary>
            /// "КонвертацияL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонвертацияL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонвертацияL", typeof(IIS.Kurs4.Конвертация));
                }
            }
        }
    }
}
