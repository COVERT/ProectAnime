//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProectAnime
{
    using System;
    using System.Collections.Generic;
    
    public partial class DealSet
    {
        public int Id_sdelka { get; set; }
        public int Id_Agent { get; set; }
        public int Id_Client { get; set; }
        public int Id_product { get; set; }
    
        public virtual AgentSet AgentSet { get; set; }
        public virtual AssortmentSet AssortmentSet { get; set; }
        public virtual ClientSet ClientSet { get; set; }
        public virtual ProviderSet ProviderSet { get; set; }
    }
}
