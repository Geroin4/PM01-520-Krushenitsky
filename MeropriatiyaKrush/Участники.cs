//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeropriatiyaKrush
{
    using System;
    using System.Collections.Generic;
    
    public partial class Участники
    {
        public string ФИО { get; set; }
        public string Почта { get; set; }
        public System.DateTime Дата_Рождения { get; set; }
        public double страна { get; set; }
        public double телефон { get; set; }
        public string пароль { get; set; }
        public string фото { get; set; }
        public string пол { get; set; }
    
        public virtual Страны Страны { get; set; }
    }
}
