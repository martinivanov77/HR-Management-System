using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies();
        Company GetCompany(int id);
        public Company Add(Company company, Office office);

    }
}
