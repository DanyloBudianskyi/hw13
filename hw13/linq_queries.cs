//Старое дз
//a)	Получить список с информацией обо всех сотрудниках
//var query = from user in serviceHR.ReadEmployees() select user;
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//b)	Получить список всех сотрудников с именем 'David'
//var query = serviceHR.ReadEmployees().Where(u => u.FirstName == "David");
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//c)	Получить список всех сотрудников с job_id равным 'IT_PROG'//Engineer
//var query = serviceHR.ReadEmployees().Where(u => u.JobId == "Engineer");
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//d)	Получить список всех сотрудников из 50го отдела (department_id) с зарплатой(salary), большей 4000
//var query = serviceHR.ReadEmployees().Where(u => u.Salary > 4000);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//e)	Получить список всех сотрудников из 20го и из 30го отдела (department_id)
//var query = serviceHR.ReadEmployees().Where(u => u.DepartmentId == 2 || u.DepartmentId == 3);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//f)	Получить список всех сотрудников у которых последняя буква в имени равна 'a'
//var query = serviceHR.ReadEmployees().Where(u => u.FirstName.EndsWith('a'));
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//g)	Получить список всех сотрудников из 50го и из 80го отдела(department_id) у которых есть бонус(значение в колонке commission_pct не пустое)
//var query = serviceHR.ReadEmployees().Where(u => 
//    u.CommissionPct != 0 && u.DepartmentId == 5 || u.DepartmentId == 8
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//h)	Получить список всех сотрудников у которых в имени содержатся минимум 2 буквы 'n'
//serviceHR.AddEmployee(11, "Brendan", "Taylor", "brendan.taylor@example.com", "555-9999", new DateTime(2018, 7, 1), "Engineer", 60000, 0.05M, 3);
//var query = serviceHR.ReadEmployees().Where(u =>
//    u.FirstName.Count(c => c == 'n' || c == 'N') >= 2
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//i)	Получить список всех сотрудников у которых зарплата находится в промежутке от 8000 до 9000 (включительно)
//var query = serviceHR.ReadEmployees().Where(u =>
//    u.Salary >= 40000 & u.Salary <= 50000
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//j)	Получить список всех сотрудников у которых в имени содержится символ '%'
//serviceHR.AddEmployee(11, "Brendan%", "Taylor", "brendan.taylor@example.com", "555-9999", new DateTime(2018, 7, 1), "Engineer", 60000, 0.05M, 3);
//var query = serviceHR.ReadEmployees().Where(u =>
//    u.FirstName.Contains('%')
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//k)	Получить список всех ID менеджеров
//var query = from emp in serviceHR.ReadEmployees()
//            where emp.JobId == "Manager"
//            select new 
//            { 
//                employeeID = emp.EmployeeId,
//                FirstName = emp.FirstName,
//                LastName = emp.LastName,
//            };
//foreach (var item in query)
//{
//    Console.WriteLine($"{item.employeeID} - {item.FirstName} {item.LastName}");
//}

//l)	Получить список всех сотрудников у которых длина имени больше 10 букв
//serviceHR.AddEmployee(11, "Christopher", "Taylor", "brendan.taylor@example.com", "555-9999", new DateTime(2018, 7, 1), "Engineer", 60000, 0.05M, 3);
//var query = serviceHR.ReadEmployees().Where(u =>
//    u.FirstName.Length > 10
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//m)	Получить список всех сотрудников у которых в имени есть буква 'b' (без учета регистра)
//serviceHR.AddEmployee(11, "Brendan", "Taylor", "brendan.taylor@example.com", "555-9999", new DateTime(2018, 7, 1), "Engineer", 60000, 0.05M, 3);
//var query = serviceHR.ReadEmployees().Where(u =>
//    u.FirstName.StartsWith('B')
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//n)	Получить список всех сотрудников у которых в имени содержатся минимум 2 буквы 'a'
//serviceHR.AddEmployee(11, "Brendan", "Taylor", "brendan.taylor@example.com", "555-9999", new DateTime(2018, 7, 1), "Engineer", 60000, 0.05M, 3);
//var query = serviceHR.ReadEmployees().Where(u =>
//    u.FirstName.Count(c => c == 'A' || c == 'a') >= 2
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//o)	Получить список всех сотрудников зарплата которых кратна 1000
//var query = serviceHR.ReadEmployees().Where(u =>
//    u.Salary % 1000 == 0
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//p)	Получить первое 3х значное число телефонного номера сотрудника если его номер в формате ХХХ.ХХХ.ХХХХ
//var query = serviceHR.ReadEmployees().Where(u =>
//    Regex.IsMatch(u.PhoneNumber, @"^\d{3}\.\d{3}\.\d{4}$")
//);
//foreach (var item in query)
//{
//    Console.WriteLine(item.PhoneNumber.Substring(0, 3));
//}

//q)	Получить первое слово из имени департамента для тех у кого в названии больше одного слова
//var query = serviceHR.ReadDepartments().Where(u => u.DepartmentName.Split(' ').Length > 1)
//    .Select(u => new { FirstWord = u.DepartmentName.Split(' ')[0] });
//foreach (var item in query)
//{
//    Console.WriteLine(item.FirstWord);
//}

//r)	Получить имена сотрудников без первой и последней буквы в имени
//var query = serviceHR.ReadEmployees().Where(u => u.FirstName.Length > 2).Select
//    (u => new { ModifiedName = u.FirstName.Substring(1, u.FirstName.Length - 2) }
//    );
//foreach (var item in query)
//{
//    Console.WriteLine(item.ModifiedName);
//}

//s)	Получить список всех сотрудников у которых последняя буква в имени равна 'm' и длинной имени большей 5ти
//serviceHR.AddEmployee(11, "William", "Wilson", "william.wilson@example.com", "555-9999", new DateTime(2018, 7, 1), "Engineer", 60000, 0.05M, 3);
//var query = serviceHR.ReadEmployees().Where(u => u.FirstName.Length > 5 && u.FirstName[u.FirstName.Length - 1] == 'm'
//    );
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//u)	Получить список сотрудников у которых менеджер получает зарплату больше 15000.
//var query = serviceHR.ReadEmployees().Where(u => u.JobId == "Manager" && u.Salary > 15000
//    );
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//v)	Показать все департаменты в которых нет ни одного сотрудника
//var query = serviceHR.ReadEmployees().Where(u => u.DepartmentId == 
//    );
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//w)	Показать всех сотрудников которые не являются менеджерами
//var query = serviceHR.ReadEmployees().Where(u => u.JobId != "Manager");
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}

//x)	Показать всех менеджеров которые имеют в подчинении больше 6ти сотрудников
//var query = serviceHR.ReadEmployees().Where(u => u.JobId == "Manager").GroupJoin(serviceHR.ReadEmployees(),
//        manager => manager.EmployeeId,
//        employee => employee.ManagerId, (manager, subordinates) => new
//        {
//            Manager = manager,
//            SubordinateCount = subordinates.Count()
//        })
//    .Where(result => result.SubordinateCount > 6);
//foreach (var item in query)
//{
//    Console.WriteLine(item.Manager.FirstName + " " + item.Manager.LastName + " have more than 6 subordinates");
//}

//y)	Показать сотрудников которые работают в департаменте IT
//var itDepartment = serviceHR.ReadDepartments().FirstOrDefault(d => d.DepartmentName == "IT");
//var query = serviceHR.ReadEmployees().Where(u => u.DepartmentId == itDepartment.DepartmentId);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}
