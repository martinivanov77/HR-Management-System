using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class MockCompanyRepository : ICompanyRepository
    {
        private List<Company> companiesList;
        public MockCompanyRepository()
        {
            this.companiesList = new List<Company>()
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

        public Company Add(Company company, Office office)
        {
            company.Id = this.companiesList.Max(c => c.Id) + 1;
            this.companiesList.Add(company);
            company.Offices = new List<Office>();
            company.Offices.Add(office);

            return company;
        }
        public IEnumerable<Company> GetAllCompanies()
        {
            return this.companiesList;
        }
        public Company GetCompany(int id)
        {
            return this.companiesList.FirstOrDefault(c => c.Id == id);
        }

    }
}
