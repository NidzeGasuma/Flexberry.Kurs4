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
    /// Еди изм.
    /// </summary>
    // *** Start programmer edit section *** (ЕдиИзм CustomAttributes)

    // *** End programmer edit section *** (ЕдиИзм CustomAttributes)
    [AutoAltered()]
    [Caption("Единицы измерения")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЕдиИзмE", new string[] {
            "Наименование as \'Наименование\'"})]
    [View("ЕдиИзмL", new string[] {
            "Наименование as \'Наименование\'"})]
    public class ЕдиИзм : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        // *** Start programmer edit section *** (ЕдиИзм CustomMembers)

        // *** End programmer edit section *** (ЕдиИзм CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (ЕдиИзм.Наименование CustomAttributes)

        // *** End programmer edit section *** (ЕдиИзм.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (ЕдиИзм.Наименование Get start)

                // *** End programmer edit section *** (ЕдиИзм.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (ЕдиИзм.Наименование Get end)

                // *** End programmer edit section *** (ЕдиИзм.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЕдиИзм.Наименование Set start)

                // *** End programmer edit section *** (ЕдиИзм.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (ЕдиИзм.Наименование Set end)

                // *** End programmer edit section *** (ЕдиИзм.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЕдиИзмE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЕдиИзмE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЕдиИзмE", typeof(IIS.Kurs4.ЕдиИзм));
                }
            }
            
            /// <summary>
            /// "ЕдиИзмL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЕдиИзмL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЕдиИзмL", typeof(IIS.Kurs4.ЕдиИзм));
                }
            }
        }
    }
}
