using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_
{
    abstract class Product
    {
        public string Name { get; set; }
        public abstract void Dispense();
    }

    class  Snack:Product
    {
        public Snack()
        {
            this.Name= "Snack";
        }
        public override void Dispense()
        {
            Console.WriteLine("Dispensing Snack");
        }
        
    }

    class Beverage:Product
    {
        public Beverage()
        {
            this.Name= "Beverage";
        }
        public override void Dispense()
        {
            Console.WriteLine("Dispensing Beverage");
        }
        
    }

    interface IVendingMachine
    {
        void SelectProduct(Product product);
        
    }

    class VendingMachine:IVendingMachine
    {
        public void SelectProduct(Product product)
        {
            product.Dispense();
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        VendingMachine vendingMachine = new VendingMachine();
    //        Product snack = new Snack();
    //        Product beverage = new Beverage();
    //        vendingMachine.SelectProduct(snack);
    //        vendingMachine.SelectProduct(beverage);
    //    }
    //}

}
