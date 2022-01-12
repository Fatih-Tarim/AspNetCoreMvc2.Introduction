using AspNetCoreMvc2.Introduction.Entities;
using System.Collections.Generic;

namespace AspNetCoreMvc2.Introduction
{
    public class employeeViewListModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}