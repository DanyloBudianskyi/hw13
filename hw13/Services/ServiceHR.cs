using collection_practice.DbContext;
using collection_practice.HR;

namespace hw13.Services
{
    public class ServiceHR
    {
        public InitHr? initHr { get; set; }
        public ServiceHR() {
            initHr = new InitHr();
        }
        //Department
        public void AddDepartment(int departmentId, string departmentName, int locationId)
        {
            Location location = initHr.locations.Find(item => item.LocationId == locationId);
            if (location != null)
            {
                initHr.departments.Add(new Department { DepartmentId = departmentId, DepartmentName = departmentName, LocationId = locationId });
            }
        }
        public List<Department> ReadDepartments()
        {
            return initHr.departments;
        }
        public void UpdateDepartment(int departmentId, string newDepartmentName, int newLocationId)
        {
            Department department = initHr.departments.Find(item => item.DepartmentId == departmentId);
            Location location = initHr.locations.Find(item => item.LocationId == newLocationId);
            if (department != null && location != null)
            {
                department.DepartmentName = newDepartmentName;
                department.LocationId = newLocationId;
            }
        }
        public void DeleteDepartment(int departmentId)
        {
            Department department = initHr.departments.Find(item => item.DepartmentId == departmentId);
            if (department != null)
            {
                initHr.departments.Remove(department);
            }
        }
        //Location
        public void AddLocation(int locationId, string streetAddress, string postalCode, string city, string stateProvince, string countryId)
        {
            Country country = initHr.countries.Find(item => item.CountryId == countryId);
            if (country != null)
            {
                initHr.locations.Add(new Location
                {
                    LocationId = locationId,
                    StreetAddress = streetAddress,
                    PostalCode = postalCode,
                    City = city,
                    StateProvince = stateProvince,
                    Country = country
                });
            }
        }
        public List<Location> ReadLocations()
        {
            return initHr.locations;
        }
        public void UpdateLocation(int locationId, string newStreetAddress, string newPostalCode, string newCity, string newStateProvince, string newCountryId)
        {
            Location location = initHr.locations.Find(item => item.LocationId == locationId);
            Country country = initHr.countries.Find(item => item.CountryId == newCountryId);
            if (location != null && country != null)
            {
                location.StreetAddress = newStreetAddress;
                location.PostalCode = newPostalCode;
                location.City = newCity;
                location.StateProvince = newStateProvince;
                location.Country = country;
            }
        }
        public void DeleteLocation(int locationId)
        {
            Location location = initHr.locations.Find(item => item.LocationId == locationId);
            if (location != null)
            {
                initHr.locations.Remove(location);
            }
        }
        //JobHistory
        public void AddJobHistory(int employeeId, DateTime startDate, DateTime endDate, string jobId, int departmentId)
        {
            Job job = initHr.jobs.Find(item => item.JobId == jobId);
            Department department = initHr.departments.Find(item => item.DepartmentId == departmentId);

            if (job != null && department != null)
            {
                initHr.jobHistories.Add(new JobHistory
                {
                    EmployeeId = employeeId,
                    StartDate = startDate,
                    EndDate = endDate,
                    JobId = jobId,
                    DepartmentId = departmentId
                });
            }
        }
        public List<JobHistory> ReadJobHistories()
        {
            return initHr.jobHistories;
        }
        public void UpdateJobHistory(int employeeId, DateTime newStartDate, DateTime newEndDate, string newJobId, int newDepartmentId)
        {
            JobHistory jobHistory = initHr.jobHistories.Find(item => item.EmployeeId == employeeId);
            Job job = initHr.jobs.Find(item => item.JobId == newJobId);
            Department department = initHr.departments.Find(item => item.DepartmentId == newDepartmentId);

            if (jobHistory != null && job != null && department != null)
            {
                jobHistory.StartDate = newStartDate;
                jobHistory.EndDate = newEndDate;
                jobHistory.JobId = newJobId;
                jobHistory.DepartmentId = newDepartmentId;
            }
        }
        public void DeleteJobHistory(int employeeId)
        {
            JobHistory jobHistory = initHr.jobHistories.Find(item => item.EmployeeId == employeeId);
            if (jobHistory != null)
            {
                initHr.jobHistories.Remove(jobHistory);
            }
        }
        //Employee
        public void AddEmployee(int employeeId, string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, string jobId, decimal salary, decimal commissionPct, int departmentId)
        {
            Job job = initHr.jobs.Find(item => item.JobId == jobId);
            Department department = initHr.departments.Find(item => item.DepartmentId == departmentId);

            if (job != null && department != null)
            {
                initHr.employees.Add(new Employee
                {
                    EmployeeId = employeeId,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    HireDate = hireDate,
                    JobId = jobId,
                    Salary = salary,
                    CommissionPct = commissionPct,
                    DepartmentId = departmentId
                });
            }
        }
        public List<Employee> ReadEmployees()
        {
            return initHr.employees;
        }
        public void UpdateEmployee(int employeeId, string newFirstName, string newLastName, string newEmail, string newPhoneNumber, DateTime newHireDate, string newJobId, decimal newSalary, decimal newCommissionPct, int newDepartmentId)
        {
            Employee? employee = initHr.employees.Find(item => item.EmployeeId == employeeId);
            Job? job = initHr.jobs.Find(item => item.JobId == newJobId);
            Department? department = initHr.departments.Find(item => item.DepartmentId == newDepartmentId);

            if (employee != null && job != null && department != null)
            {
                employee.FirstName = newFirstName;
                employee.LastName = newLastName;
                employee.Email = newEmail;
                employee.PhoneNumber = newPhoneNumber;
                employee.HireDate = newHireDate;
                employee.JobId = newJobId;
                employee.Salary = newSalary;
                employee.CommissionPct = newCommissionPct;
                employee.DepartmentId = newDepartmentId;
            }
        }
        public void DeleteEmployee(int employeeId)
        {
            Employee? employee = initHr.employees.Find(item => item.EmployeeId == employeeId);
            if (employee != null)
            {
                initHr.employees.Remove(employee);
            }
        }
        //prints
        public void printRegions()
        {
            foreach (var item in initHr.regions)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public void printCoutnries()
        {
            foreach (var item in initHr.countries)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public void printDepartments()
        {
            foreach (var item in initHr.departments)
            {
                var location = initHr.locations.FirstOrDefault(l => l.LocationId == item.LocationId);
                Console.WriteLine(item);
                if (location != null)
                {
                    Console.WriteLine($"Location city: {location.City}, Country: {location.Country?.CountryName}\n");
                }
            }
            Console.WriteLine();
        }
        public void printEmployees()
        {
            foreach (var item in initHr.employees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public void printJobs()
        {
            foreach (var item in initHr.jobs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public void printJobsHistory()
        {
            foreach (var item in initHr.jobHistories)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public void printLocation()
        {
            foreach (var item in initHr.locations)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        //Методы для дз linq2
        public void updateLocationCountry(int locationId, Country newCountry)
        {
            var location = initHr.locations.FirstOrDefault(c => c.LocationId == locationId);
            if (location != null) location.Country = newCountry;
        }
        public List<Country> ReadCountries()
        {
            return initHr.countries;
        }
        public List<Location> CreateLocationsForCities(List<Location> locations, List<string> cities)
        {
            return locations.Where(l => cities.Contains(l.City)).ToList();
        }

        public void updateDepartmentCountry(int departmentId, Country newCountry)
        {
            var department = initHr.departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                var location = initHr.locations.FirstOrDefault(l => l.LocationId == department.LocationId);
                if (location != null) location.Country = newCountry;
            }
        }

        public List<Location> CreateLocationsForPostalCode(List<Location> locations, List<string> postalCodes)
        {
            return locations.Where(l => postalCodes.Contains(l.PostalCode)).ToList();
        }
    }
}
