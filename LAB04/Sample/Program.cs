using OOP_COLLECTIONS;
using System;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // 1. Cоздать отдел с названием "IT"
        // =========================
        Department dept = new Department("IT");

        // =========================
        // 2. Cоздать 2-х рабочих
        // =========================
        Worker w1 = new Worker("Artem", 1000, 22);
        Worker w2 = new Worker("Vlad", 1100, 18);

        // =========================
        // 3. Cоздать 2-х программистов
        // =========================
        Programmer p1 = new Programmer("Sasha", 2000, "Junior");
        Programmer p2 = new Programmer("Andrey", 3000, "Senior");

        // =========================
        // 4. Cоздать 1-го менеджера
        // =========================
        Manager m1 = new Manager("Vasya", 2500, 9);

        // =========================
        // 5. Добавить всех сотрудников в отдел
        // =========================
        dept.AddEmployee(w1);
        dept.AddEmployee(w2);
        dept.AddEmployee(p1);
        dept.AddEmployee(p2);
        dept.AddEmployee(m1);

        // =========================
        // 6. Вывести всех сотрудников отдела
        // =========================
        Console.WriteLine("=== Все сотрудники отдела ===");
        dept.ShowAllEmployees();

        // =========================
        // 7. Найти сотрудников с Id 1, 3, 7 и вывести информацию о них
        // =========================
        Console.WriteLine("\n=== Тестируем поиск сотрудника ===");

        int[] ids = { 1, 3, 7 };
        foreach (int id in ids)
        {
            Employee emp = dept.FindEmployeeById(id);
            if (emp != null)
            {
                Console.WriteLine($"Найден сотрудник с ID {id}:");
                emp.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"Сотрудник с ID {id} не найден");
            }
        }

        // =========================
        // 8. Удалить сотрудника с Id = 2
        // =========================
        Console.WriteLine("\n=== Тестируем удаление сотрудника ===");

        bool removed = dept.RemoveEmployeeById(2);
        Console.WriteLine(removed
            ? "Сотрудник удалён"
            : "Сотрудник не найден");

        // =========================
        // 9. Вывести всех сотрудников отдела после удаления
        // =========================
        Console.WriteLine("\n=== После удаления ===");
        dept.ShowAllEmployees();

        // =========================
        // 10. Вывести на экран сводную информацию об отделе
        // =========================
        Console.WriteLine("\n=== Статистика Отдела ===");
        dept.GetDepartmentInfo();
    }
}