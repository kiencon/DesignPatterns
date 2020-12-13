using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    abstract class ProductBuilder
    {
        public abstract void BuildName();

        public abstract void BuildPrice();

        public abstract void BuildDescription();

        public abstract void BuildProducer();

        public abstract void BuildTax();

        public abstract void BuildBoxPacking();

        public abstract void BuildExport();

        public abstract Product GetProduct();
    }
}
