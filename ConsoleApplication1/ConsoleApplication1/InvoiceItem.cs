using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InvoiceItem
    {
        private string id;
        private string desc;
        private int qty;
        private double unitPrice;
        public InvoiceItem(string id, string desc, int qty, double unitPrice)
        {
            this.id = id;
            this.desc = desc;
            this.qty = qty;
            this.unitPrice = unitPrice;
        }
        public string getID()
        {
            return this.id;
        }
        public string getDesc()
        {
            return this.desc;
        }
        public int getQty()
        {
            return this.qty;
        }
        public double getUnitPrice()
        {
            return this.unitPrice;
        }
        public void setUnitPrice(double newUnitPrice)
        {
            this.unitPrice = newUnitPrice;
        }
        public double getTotal()
        {
            return this.unitPrice * this.qty;
        }
        public string toString()
        {
            return string.Format("InvoiceItem[id = {0}, desc = {1}, qty = {2}, unitPrice = {3}]", this.id, this.desc, this.qty, this.unitPrice);
        }
    }
}
