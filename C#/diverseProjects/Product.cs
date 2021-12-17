using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diverseProjects
{
    internal class Product
    {
        private string _name { get; set; }
        private double _price { get; set; }
        private string _description { get; set; }
        private int _quantity { get; set; }

        public Product(string name, double price, string description, int quantity = 10) {
            this._name = name;
            this._price = price;
            this._description = description;
            this._quantity = quantity;
        }

        public string GetName() {
            return this._name;
        }

        public void SetName(string name) {
            this._name = name;
        }

        public double GetPrice() {
            return this._price;
        }

        public void SetPrice(double price) {
            this._price = price;
        }

        public string GetDescription() {
            return this._description;
        }

        public void SetDescription(string description) {
            this._description = description;
        }

        public int GetQuantity() {
            return this._quantity;
        }

        public void SetQuantity(int quantity) {
            this._quantity = quantity;
        }

        public void ListInformations() {
            Console.WriteLine($"Nome = {_name}, Preço = {_price}, Descrição = {_description}, Quantidade = {_quantity}.");
        }
    }
}
