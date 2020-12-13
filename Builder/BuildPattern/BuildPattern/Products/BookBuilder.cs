using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.Products
{
    class BookBuilder : ProductBuilder
    {
        private Product _product = new Product();

        public override void BuildBoxPacking()
        {
            _product.Add("Box size :", BoxSize.Small.ToString());
        }

        public override void BuildDescription()
        {
            _product.Add("Description :", "Design Pattern.");
        }

        public override void BuildExport() { }

        public override void BuildName()
        {
            _product.Add("Name :", "Book");
        }

        public override void BuildPrice()
        {
            _product.Add("Price :", "268,000");
        }

        public override void BuildProducer()
        {
            _product.Add("Producer :", Producer.CompanyXYZ.ToString());
        }

        public override void BuildTax() { }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}
