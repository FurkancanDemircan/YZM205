using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class RestaurantSystem
    {
        private List<Customer> _customers;
        private List<DeliveryDriver> _drivers;
        private List<Order> _orders;
        private List<FoodItem> _menu;

        public RestaurantSystem()
        {
            _customers = new List<Customer>();
            _drivers = new List<DeliveryDriver>();
            _orders = new List<Order>();
            _menu = new List<FoodItem>();
        }

        public void RegisterCustomer(string name, string email)
        {
            _customers.Add(new Customer(name, _customers.Count + 1, email));
        }
        public void AddDriver(string name)
        {
            _drivers.Add(new DeliveryDriver(_drivers.Count + 1, name));
        }

        public void AddMenuItem(FoodItem item)
        {
            _menu.Add(item);
        }

        public DeliveryDriver AssignDriver()
        {
            _drivers.Sort();
            var driver = _drivers.First();
            driver.AssignDriver();
            return driver;
        }

        public Order CreateOrder(Customer customer, List<int> menuIndex)
        {
            var order = new Order(customer);
            foreach (var item in menuIndex)
            {
                order.AddItem(_menu[item]);
            }
            return order;
        }
    }
}
