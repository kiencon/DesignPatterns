using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.Products
{

    class BagBuilder : ProductBuilder
    {
        private Product _product = new Product();

        public override void BuildBoxPacking()
        {
            _product.Add("Box Size: ", BoxSize.Small.ToString());
        }

        public override void BuildDescription()
        {
            _product.Add("Description :", "This is a bag.");
        }

        public override void BuildExport()
        {
            _product.Add("Export :", "true");
        }

        public override void BuildName()
        {
            _product.Add("Name :", "Bag");
        }

        public override void BuildPrice()
        {
            _product.Add("Price :", "1,500,000");
        }

        public override void BuildProducer()
        {
            _product.Add("Producer: ", Producer.CompanyDEF.ToString());
        }

        public override void BuildTax()
        {
            _product.Add("Tax: ", "10%");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}
