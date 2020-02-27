using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class MockCompanyRepository : ICompanyRepository
    {
        private List<Company> companies;
        public MockCompanyRepository()
        {
            this.companies = new List<Company>()
            {
                new Company
                { 
                    Id = 1,
                    Name = "Wall Street Code",
                    CreationDate = new DateTime(2000, 10, 10),
                    Offices = new List<Office>() { new Office { Country = "USA", City = "New York", Street = "Wall Street", StreetNumber = 10, IsHQ = true } }
                },
                 new Company
                {
                    Id = 2,
                    Name = "London Coders",
                    CreationDate = new DateTime(2005, 10, 10),
                    Offices = new List<Office>() { new Office { Country = "UK", City = "London", Street = "Cannon Street", StreetNumber = 10, IsHQ = true } }
                }
            };
        }
 
        public IEnumerable<Company> GetAllCompanies()
        {
            return this.companies;
        }
        public Company GetCompany(int id)
        {
            return this.companies.FirstOrDefault(company => company.Id == id);
        }
    }
}
