using collection_practice.HR;

namespace collection_practice.DbContext
{
    public class InitHr
    {
        public List<Region> regions {  get; set; }
        public List<Country> countries {  get; set; }
        public List<Location> locations {  get; set; }
        public List<Department> departments {  get; set; }
        public List<Job> jobs {  get; set; }
        public List<JobHistory> jobHistories {  get; set; }
        public List<Employee> employees {  get; set; }
        public InitHr() {
            regions = InitializeRegions();
            countries = InitializeCountries();
            locations = InitializeLocations();
            departments = InitializeDepartments();
            jobs = InitializeJobs();
            jobHistories = InitializeJobsHistories();
            employees = InitializeEmployees();
        }
        private List<Region> InitializeRegions()
        {
            regions = new List<Region>();

            Region region1 = new Region
            {
                RegionId = 1,
                RegionName = "North America"
            };
            regions.Add(region1);

            Region region2 = new Region
            {
                RegionId = 2,
                RegionName = "Europe"
            };
            regions.Add(region2);

            Region region3 = new Region
            {
                RegionId = 3,
                RegionName = "Asia"
            };
            regions.Add(region3);

            Region region4 = new Region
            {
                RegionId = 4,
                RegionName = "South America"
            };
            regions.Add(region4);

            Region region5 = new Region
            {
                RegionId = 5,
                RegionName = "Africa"
            };
            regions.Add(region5);

            Region region6 = new Region
            {
                RegionId = 6,
                RegionName = "Oceania"
            };
            regions.Add(region6);

            Region region7 = new Region
            {
                RegionId = 7,
                RegionName = "Middle East"
            };
            regions.Add(region7);

            Region region8 = new Region
            {
                RegionId = 8,
                RegionName = "Central America"
            };
            regions.Add(region8);

            Region region9 = new Region
            {
                RegionId = 9,
                RegionName = "Caribbean"
            };
            regions.Add(region9);

            Region region10 = new Region
            {
                RegionId = 10,
                RegionName = "Antarctica"
            };
            regions.Add(region10);
            return regions;
        }
        private List<Country> InitializeCountries()
        {
            List<Region> regions = InitializeRegions();
            countries = new List<Country>();
            Country country1 = new Country
            {
                CountryId = "US",
                CountryName = "United States",
                Region = regions[0]
            };
            countries.Add(country1);

            Country country2 = new Country
            {
                CountryId = "CA",
                CountryName = "Canada",
                Region = regions[0]
            };
            countries.Add(country2);

            Country country3 = new Country
            {
                CountryId = "UK",
                CountryName = "United Kingdom",
                Region = regions[1]
            };
            countries.Add(country3);

            Country country4 = new Country
            {
                CountryId = "FR",
                CountryName = "France",
                Region = regions[1]
            };
            countries.Add(country4);

            Country country5 = new Country
            {
                CountryId = "JP",
                CountryName = "Japan",
                Region = regions[2]
            };
            countries.Add(country5);

            Country country6 = new Country
            {
                CountryId = "AU",
                CountryName = "Australia",
                Region = regions[5]
            };
            countries.Add(country6);

            Country country7 = new Country
            {
                CountryId = "CN",
                CountryName = "China",
                Region = regions[2]
            };
            countries.Add(country7);

            Country country8 = new Country
            {
                CountryId = "BR",
                CountryName = "Brazil",
                Region = regions[3]
            };
            countries.Add(country8);

            Country country9 = new Country
            {
                CountryId = "ZA",
                CountryName = "South Africa",
                Region = regions[4]
            };
            countries.Add(country9);

            Country country10 = new Country
            {
                CountryId = "RU",
                CountryName = "Russia",
                Region = regions[1]
            };
            countries.Add(country10);
            return countries;
        }
        private List<Location> InitializeLocations()
        {
            locations = new List<Location>();
            countries = InitializeCountries();
            Location location1 = new Location
            {
                LocationId = 1,
                StreetAddress = "123 Main St",
                PostalCode = "12345",
                City = "City 1",
                StateProvince = "State 1",
                Country = countries[0]
            };
            locations.Add(location1);

            Location location2 = new Location
            {
                LocationId = 2,
                StreetAddress = "456 Elm St",
                PostalCode = "54321",
                City = "City 2",
                StateProvince = "State 2",
                Country = countries[1]
            };
            locations.Add(location2);

            Location location3 = new Location
            {
                LocationId = 3,
                StreetAddress = "789 Oak St",
                PostalCode = "67890",
                City = "City 3",
                StateProvince = "State 3",
                Country = countries[2]
            };
            locations.Add(location3);

            Location location4 = new Location
            {
                LocationId = 4,
                StreetAddress = "101 Pine St",
                PostalCode = "11111",
                City = "City 4",
                StateProvince = "State 4",
                Country = countries[3]
            };
            locations.Add(location4);

            Location location5 = new Location
            {
                LocationId = 5,
                StreetAddress = "202 Cedar St",
                PostalCode = "22222",
                City = "City 5",
                StateProvince = "State 5",
                Country = countries[4]
            };
            locations.Add(location5);

            Location location6 = new Location
            {
                LocationId = 6,
                StreetAddress = "303 Birch St",
                PostalCode = "33333",
                City = "City 6",
                StateProvince = "State 6",
                Country = countries[5]
            };
            locations.Add(location6);

            Location location7 = new Location
            {
                LocationId = 7,
                StreetAddress = "404 Pine St",
                PostalCode = "44444",
                City = "City 7",
                StateProvince = "State 7",
                Country = countries[6]
            };
            locations.Add(location7);

            Location location8 = new Location
            {
                LocationId = 8,
                StreetAddress = "505 Maple St",
                PostalCode = "55555",
                City = "City 8",
                StateProvince = "State 8",
                Country = countries[7]
            };
            locations.Add(location8);

            Location location9 = new Location
            {
                LocationId = 9,
                StreetAddress = "606 Oak St",
                PostalCode = "66666",
                City = "City 9",
                StateProvince = "State 9",
                Country = countries[8]
            };
            locations.Add(location9);

            Location location10 = new Location
            {
                LocationId = 10,
                StreetAddress = "707 Elm St",
                PostalCode = "77777",
                City = "City 10",
                StateProvince = "State 10",
                Country = countries[9]
            };
            locations.Add(location10);
            return locations;
        }
        private List<Department> InitializeDepartments()
        {
            departments = new List<Department>();
            List<Location> locations = InitializeLocations();

            Department department1 = new Department
            {
                DepartmentId = 1,
                DepartmentName = "HR",
                LocationId = locations[0].LocationId
            };
            departments.Add(department1);

            Department department2 = new Department
            {
                DepartmentId = 2,
                DepartmentName = "Sales",
                LocationId = locations[1].LocationId
            };
            departments.Add(department2);

            Department department3 = new Department
            {
                DepartmentId = 3,
                DepartmentName = "Finance",
                LocationId = locations[2].LocationId
            };
            departments.Add(department3);

            Department department4 = new Department
            {
                DepartmentId = 4,
                DepartmentName = "Marketing",
                LocationId = locations[3].LocationId
            };
            departments.Add(department4);

            Department department5 = new Department
            {
                DepartmentId = 5,
                DepartmentName = "IT",
                LocationId = locations[4].LocationId
            };
            departments.Add(department5);

            Department department6 = new Department
            {
                DepartmentId = 6,
                DepartmentName = "Operations",
                LocationId = locations[5].LocationId
            };
            departments.Add(department6);

            Department department7 = new Department
            {
                DepartmentId = 7,
                DepartmentName = "Customer Service",
                LocationId = locations[6].LocationId
            };
            departments.Add(department7);

            Department department8 = new Department
            {
                DepartmentId = 8,
                DepartmentName = "Research and Development",
                LocationId = locations[7].LocationId
            };
            departments.Add(department8);

            Department department9 = new Department
            {
                DepartmentId = 9,
                DepartmentName = "Quality Control",
                LocationId = locations[8].LocationId
            };
            departments.Add(department9);

            Department department10 = new Department
            {
                DepartmentId = 10,
                DepartmentName = "Logistics",
                LocationId = locations[9].LocationId
            };
            departments.Add(department10);
            return departments;
        }
        private List<Job> InitializeJobs()
        {
            jobs = new List<Job>();
            Job job1 = new Job
            {
                JobId = "Manager",
                JobTitle = "Manager",
                MinSalary = 50000,
                MaxSalary = 80000
            };
            jobs.Add(job1);

            Job job2 = new Job
            {
                JobId = "SalesRep",
                JobTitle = "Sales Representative",
                MinSalary = 30000,
                MaxSalary = 60000
            };
            jobs.Add(job2);

            Job job3 = new Job
            {
                JobId = "Accountant",
                JobTitle = "Accountant",
                MinSalary = 40000,
                MaxSalary = 70000
            };
            jobs.Add(job3);

            Job job4 = new Job
            {
                JobId = "Engineer",
                JobTitle = "Software Engineer",
                MinSalary = 60000,
                MaxSalary = 100000
            };
            jobs.Add(job4);

            Job job5 = new Job
            {
                JobId = "Analyst",
                JobTitle = "Business Analyst",
                MinSalary = 45000,
                MaxSalary = 80000
            };
            jobs.Add(job5);

            Job job6 = new Job
            {
                JobId = "Designer",
                JobTitle = "Graphic Designer",
                MinSalary = 35000,
                MaxSalary = 60000
            };
            jobs.Add(job6);

            Job job7 = new Job
            {
                JobId = "Assistant",
                JobTitle = "Administrative Assistant",
                MinSalary = 30000,
                MaxSalary = 50000
            };
            jobs.Add(job7);

            Job job8 = new Job
            {
                JobId = "Clerk",
                JobTitle = "Office Clerk",
                MinSalary = 25000,
                MaxSalary = 40000
            };
            jobs.Add(job8);

            Job job9 = new Job
            {
                JobId = "Supervisor",
                JobTitle = "Supervisor",
                MinSalary = 45000,
                MaxSalary = 75000
            };
            jobs.Add(job9);

            Job job10 = new Job
            {
                JobId = "Technician",
                JobTitle = "Maintenance Technician",
                MinSalary = 35000,
                MaxSalary = 60000
            };
            jobs.Add(job10);
            return jobs;
        }
        private List<JobHistory> InitializeJobsHistories()
        {
            List<Job> job = InitializeJobs();
            List<Department> department = InitializeDepartments();
            jobHistories = new List<JobHistory>();
            JobHistory jobHistory1 = new JobHistory
            {
                EmployeeId = 1,
                StartDate = new DateTime(2020, 1, 1),
                EndDate = new DateTime(2021, 6, 30),
                JobId = job[0].JobId,
                DepartmentId = department[0].DepartmentId
            };
            jobHistories.Add(jobHistory1);

            JobHistory jobHistory2 = new JobHistory
            {
                EmployeeId = 2,
                StartDate = new DateTime(2019, 5, 1),
                EndDate = new DateTime(2020, 12, 31),
                JobId = job[1].JobId,
                DepartmentId = department[1].DepartmentId
            };
            jobHistories.Add(jobHistory2);

            JobHistory jobHistory3 = new JobHistory
            {
                EmployeeId = 3,
                StartDate = new DateTime(2020, 3, 15),
                EndDate = new DateTime(2022, 2, 28),
                JobId = job[2].JobId,
                DepartmentId = department[2].DepartmentId
            };
            jobHistories.Add(jobHistory3);

            JobHistory jobHistory4 = new JobHistory
            {
                EmployeeId = 4,
                StartDate = new DateTime(2018, 7, 1),
                EndDate = new DateTime(2020, 4, 30),
                JobId = job[3].JobId,
                DepartmentId = department[3].DepartmentId
            };
            jobHistories.Add(jobHistory4);

            JobHistory jobHistory5 = new JobHistory
            {
                EmployeeId = 5,
                StartDate = new DateTime(2019, 10, 1),
                EndDate = new DateTime(2021, 9, 30),
                JobId = job[4].JobId,
                DepartmentId = department[4].DepartmentId
            };
            jobHistories.Add(jobHistory5);

            JobHistory jobHistory6 = new JobHistory
            {
                EmployeeId = 6,
                StartDate = new DateTime(2019, 2, 15),
                EndDate = new DateTime(2020, 8, 31),
                JobId = job[5].JobId,
                DepartmentId = department[5].DepartmentId
            };
            jobHistories.Add(jobHistory6);

            JobHistory jobHistory7 = new JobHistory
            {
                EmployeeId = 7,
                StartDate = new DateTime(2020, 8, 1),
                EndDate = new DateTime(2021, 12, 31),
                JobId = job[6].JobId,
                DepartmentId = department[6].DepartmentId
            };
            jobHistories.Add(jobHistory7);

            JobHistory jobHistory8 = new JobHistory
            {
                EmployeeId = 8,
                StartDate = new DateTime(2018, 4, 1),
                EndDate = new DateTime(2019, 10, 31),
                JobId = job[7].JobId,
                DepartmentId = department[7].DepartmentId
            };
            jobHistories.Add(jobHistory8);

            JobHistory jobHistory9 = new JobHistory
            {
                EmployeeId = 9,
                StartDate = new DateTime(2019, 11, 1),
                EndDate = new DateTime(2021, 7, 31),
                JobId = job[8].JobId,
                DepartmentId = department[8].DepartmentId
            };
            jobHistories.Add(jobHistory9);

            JobHistory jobHistory10 = new JobHistory
            {
                EmployeeId = 10,
                StartDate = new DateTime(2020, 7, 1),
                EndDate = new DateTime(2022, 6, 30),
                JobId = job[9].JobId,
                DepartmentId = department[9].DepartmentId
            };
            jobHistories.Add(jobHistory10);
            return jobHistories;
        }
        private List<Employee> InitializeEmployees()
        {
            List<Job> job = InitializeJobs();
            List<Department> department = InitializeDepartments();
            employees = new List<Employee>();
            Employee employee1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "555-123-4567",
                HireDate = new DateTime(2020, 1, 15),
                JobId = job[0].JobId,
                Salary = 65000,
                CommissionPct = 0.1m,
                ManagerId = 0,
                DepartmentId = department[0].DepartmentId
            };
            employees.Add(employee1);

            Employee employee2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                PhoneNumber = "555-234-5678",
                HireDate = new DateTime(2019, 5, 20),
                JobId = job[1].JobId,
                Salary = 55000,
                CommissionPct = 0.08m,
                ManagerId = 1, // Указываем ID менеджера (employee1)
                DepartmentId = department[1].DepartmentId
            };
            employees.Add(employee2);

            Employee employee3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                Email = "michael.johnson@example.com",
                PhoneNumber = "555-345-6789",
                HireDate = new DateTime(2021, 3, 10),
                JobId = job[2].JobId,
                Salary = 60000,
                CommissionPct = 0.09m,
                ManagerId = 0,
                DepartmentId = department[2].DepartmentId
            };
            employees.Add(employee3);

            Employee employee4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Emily",
                LastName = "Wilson",
                Email = "emily.wilson@example.com",
                PhoneNumber = "555-456-7890",
                HireDate = new DateTime(2018, 7, 5),
                JobId = job[3].JobId,
                Salary = 75000,
                CommissionPct = 0.12m,
                ManagerId = 1, // Указываем ID менеджера (employee1)
                DepartmentId = department[3].DepartmentId
            };
            employees.Add(employee4);

            Employee employee5 = new Employee
            {
                EmployeeId = 5,
                FirstName = "David",
                LastName = "Brown",
                Email = "david.brown@example.com",
                PhoneNumber = "555-567-8901",
                HireDate = new DateTime(2019, 10, 3),
                JobId = job[4].JobId,
                Salary = 60000,
                CommissionPct = 0.1m,
                ManagerId = 2, // Указываем ID менеджера (employee2)
                DepartmentId = department[4].DepartmentId
            };
            employees.Add(employee5);

            Employee employee6 = new Employee
            {
                EmployeeId = 6,
                FirstName = "Sarah",
                LastName = "Davis",
                Email = "sarah.davis@example.com",
                PhoneNumber = "555-678-9012",
                HireDate = new DateTime(2020, 2, 20),
                JobId = job[5].JobId,
                Salary = 50000,
                CommissionPct = 0.07m,
                ManagerId = 3, // Указываем ID менеджера (employee3)
                DepartmentId = department[5].DepartmentId
            };
            employees.Add(employee6);

            Employee employee7 = new Employee
            {
                EmployeeId = 7,
                FirstName = "James",
                LastName = "Clark",
                Email = "james.clark@example.com",
                PhoneNumber = "555-789-0123",
                HireDate = new DateTime(2021, 8, 10),
                JobId = job[6].JobId,
                Salary = 45000,
                CommissionPct = 0.06m,
                ManagerId = 3, // Указываем ID менеджера (employee3)
                DepartmentId = department[6].DepartmentId
            };
            employees.Add(employee7);

            Employee employee8 = new Employee
            {
                EmployeeId = 8,
                FirstName = "Linda",
                LastName = "Martinez",
                Email = "linda.martinez@example.com",
                PhoneNumber = "555-890-1234",
                HireDate = new DateTime(2018, 4, 15),
                JobId = job[7].JobId,
                Salary = 40000,
                CommissionPct = 0.05m,
                ManagerId = 4, // Указываем ID менеджера (employee4)
                DepartmentId = department[7].DepartmentId
            };
            employees.Add(employee8);

            Employee employee9 = new Employee
            {
                EmployeeId = 9,
                FirstName = "Kevin",
                LastName = "Harris",
                Email = "kevin.harris@example.com",
                PhoneNumber = "555-901-2345",
                HireDate = new DateTime(2019, 11, 5),
                JobId = job[8].JobId,
                Salary = 52000,
                CommissionPct = 0.08m,
                ManagerId = 5, // Указываем ID менеджера (employee5)
                DepartmentId = department[8].DepartmentId
            };
            employees.Add(employee9);

            Employee employee10 = new Employee
            {
                EmployeeId = 10,
                FirstName = "Laura",
                LastName = "Young",
                Email = "laura.young@example.com",
                PhoneNumber = "555-012-3456",
                HireDate = new DateTime(2020, 7, 1),
                JobId = job[9].JobId,
                Salary = 48000,
                CommissionPct = 0.07m,
                ManagerId = 7, // Указываем ID менеджера (employee7)
                DepartmentId = department[9].DepartmentId
            };
            employees.Add(employee10);
            return employees;
        }
    }
}