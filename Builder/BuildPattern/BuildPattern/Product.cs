using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public class Product
    {
        private Dictionary<string, string> _productParts = new Dictionary<string, string>();

        public void Add(string partTitle, string partValue)
        {
            _productParts.Add(partTitle, partValue);
        }
        public override string ToString()
        {
            string dictionaryString = "";
            foreach (var _productPart in _productParts)
            {
                dictionaryString += _productPart.Key + " " + _productPart.Value + "\n";
            }
            return dictionaryString;
        }
    }
}
