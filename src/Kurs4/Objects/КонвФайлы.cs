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
    /// Конв файлы.
    /// </summary>
    // *** Start programmer edit section *** (КонвФайлы CustomAttributes)

    // *** End programmer edit section *** (КонвФайлы CustomAttributes)
    [AutoAltered()]
    [Caption("Конвертированные файлы")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КонвФайлыE", new string[] {
            "ПутьФайла as \'Путь файла\'",
            "ВыгрФайла as \'Новое имя\'",
            "ВыгрФайла.NewName as \'Новое имя\'",
            "ВыгрФайла.Конвертация.ИмяДок as \'Имя документа\'",
            "ВыгрФайла.Конвертация.ЗагрФайла.ЭксФайлы.Имя as \'Старое имя\'"}, Hidden=new string[] {
            "ВыгрФайла.NewName"})]
    [MasterViewDefineAttribute("КонвФайлыE", "ВыгрФайла", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "NewName")]
    [View("КонвФайлыL", new string[] {
            "ПутьФайла as \'Путь до файла\'",
            "ВыгрФайла.NewName as \'Новое имя\'",
            "ВыгрФайла.Конвертация.ИмяДок as \'Имя документа\'",
            "ВыгрФайла.Конвертация.ЗагрФайла.ЭксФайлы.Имя as \'Старое имя\'"})]
    public class КонвФайлы : ICSSoft.STORMNET.DataObject
    {
        
        private string fПутьФайла;
        
        private IIS.Kurs4.ВыгрФайла fВыгрФайла;
        
        // *** Start programmer edit section *** (КонвФайлы CustomMembers)

        // *** End programmer edit section *** (КонвФайлы CustomMembers)

        
        /// <summary>
        /// ПутьФайла.
        /// </summary>
        // *** Start programmer edit section *** (КонвФайлы.ПутьФайла CustomAttributes)

        // *** End programmer edit section *** (КонвФайлы.ПутьФайла CustomAttributes)
        [StrLen(255)]
        public virtual string ПутьФайла
        {
            get
            {
                // *** Start programmer edit section *** (КонвФайлы.ПутьФайла Get start)

                // *** End programmer edit section *** (КонвФайлы.ПутьФайла Get start)
                string result = this.fПутьФайла;
                // *** Start programmer edit section *** (КонвФайлы.ПутьФайла Get end)

                // *** End programmer edit section *** (КонвФайлы.ПутьФайла Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонвФайлы.ПутьФайла Set start)

                // *** End programmer edit section *** (КонвФайлы.ПутьФайла Set start)
                this.fПутьФайла = value;
                // *** Start programmer edit section *** (КонвФайлы.ПутьФайла Set end)

                // *** End programmer edit section *** (КонвФайлы.ПутьФайла Set end)
            }
        }
        
        /// <summary>
        /// Конв файлы.
        /// </summary>
        // *** Start programmer edit section *** (КонвФайлы.ВыгрФайла CustomAttributes)

        // *** End programmer edit section *** (КонвФайлы.ВыгрФайла CustomAttributes)
        [PropertyStorage(new string[] {
                "ВыгрФайла"})]
        [NotNull()]
        public virtual IIS.Kurs4.ВыгрФайла ВыгрФайла
        {
            get
            {
                // *** Start programmer edit section *** (КонвФайлы.ВыгрФайла Get start)

                // *** End programmer edit section *** (КонвФайлы.ВыгрФайла Get start)
                IIS.Kurs4.ВыгрФайла result = this.fВыгрФайла;
                // *** Start programmer edit section *** (КонвФайлы.ВыгрФайла Get end)

                // *** End programmer edit section *** (КонвФайлы.ВыгрФайла Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (КонвФайлы.ВыгрФайла Set start)

                // *** End programmer edit section *** (КонвФайлы.ВыгрФайла Set start)
                this.fВыгрФайла = value;
                // *** Start programmer edit section *** (КонвФайлы.ВыгрФайла Set end)

                // *** End programmer edit section *** (КонвФайлы.ВыгрФайла Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КонвФайлыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонвФайлыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонвФайлыE", typeof(IIS.Kurs4.КонвФайлы));
                }
            }
            
            /// <summary>
            /// "КонвФайлыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонвФайлыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонвФайлыL", typeof(IIS.Kurs4.КонвФайлы));
                }
            }
        }
    }
}
