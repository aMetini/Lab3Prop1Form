using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3Prop1
{
    public partial class StockBalance
    {
        public int BoutiqueId { get; set; }
        public long Isbn { get; set; }
        public int? Number { get; set; }

        public virtual Store Boutique { get; set; }
        public virtual Book IsbnNavigation { get; set; }
    }
}
