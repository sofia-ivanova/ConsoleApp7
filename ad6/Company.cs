using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ad6
{
    internal class Company
    {
        private List<Employee> employees;
        public Company(List<Employee> employees)
        {
            this.employees = employees;
            SelectionSort(this.employees);
        }
        private void SelectionSort(List<Employee> employees)
        {
            int n = employees.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (employees[j].Salary < employees[minIndex].Salary)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Employee temp = employees[i];
                    employees[i] = employees[minIndex];
                    employees[minIndex] = temp;
                }
            }
        }

        public string FindEmployeeBySalary(int salary)
        {
            int left = 0, right = employees.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (employees[mid].Salary == salary)
                    return employees[mid].Name;
                else if (employees[mid].Salary < salary)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return "Не е намерен";
        }
    }
}
