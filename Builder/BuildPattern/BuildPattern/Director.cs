using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    class Director
    {
        public void Construct(ProductBuilder builder)
        {
            builder.BuildName();
            builder.BuildDescription();
            builder.BuildProducer();
            builder.BuildBoxPacking();
            builder.BuildPrice();
            builder.BuildTax();
            builder.BuildExport();
        }
    }
}
