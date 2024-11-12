using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public string Country { get; set; }

        public DateOnly RegisterDate { get; set; }
        public TimeOnly MeanProcessTime { get; set; }
    }
    public class CustomerService
    {
        private List<Customer> customers = new()
        {
            new(){ Id=1, Name="Softtech", Budget=1500000, Country="Türkiye"},
            new(){ Id=2, Name="Kardeşler İnşaat", Budget=150000, Country="Türkiye"},
            new(){ Id=3, Name="Northwind", Budget=750000, Country="Amerika"},
            new(){ Id=4, Name="Contoso", Budget=1750000, Country="UK"},
            new(){ Id=5, Name="Amazon", Budget=750000, Country="Amerika"}
        };

        public List<Customer> GetCustomers() => customers;
    }
}
