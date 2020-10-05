using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Система учета рабочего времени сотрудников предприятия.
    /// </summary>
    class TimeTrackingSystem
    {
        /// <summary>
        /// Единственный экземпляр системы учета времени.
        /// </summary>
        static Lazy<TimeTrackingSystem> system = new Lazy<TimeTrackingSystem>(() => new TimeTrackingSystem());
        public static TimeTrackingSystem System
        {
            get
            {
                return system.Value;
            }
        }
        /// <summary>
        /// Список сотрудников, находящихся на работе в текущее время.
        /// </summary>
        private List<EmployeeFactory> employees;

        /// <summary>
        /// Закрытый конструктор, определяющий список сотрудников, находящихся на предприятии.
        /// </summary>
        private TimeTrackingSystem() 
        {
            employees = new List<EmployeeFactory>();
        }

        /// <summary>
        /// Добавление сотрудника с указанным идентификатором в список сотрудников, находящихся на предприятии в текущее время.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool addEmployee(int id)
        {
            try
            {
                employees.Add(createEmployee(id));
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Обновление данных о сотруднике с указанным идентификатором.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool updateEmployee(int id)
        {
            try
            {
                int number = findEmployee(id);
                if (employees[number].endWork())
                {
                    return true;
                }                    
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
        /// <summary>
        /// Сохранение данных о сторуднике с указанным идентификатором.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool saveEmployee(int id)
        {
            try
            {
                int number = findEmployee(id);
                if (employees[number].saveWork())
                {
                    return true;
                }
                
                return false;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Удаление сотрудника с указанным идентификатором из списка сотрудников, находящихся в текущее время на работе.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool deleteEmployee(int id)
        {
            try
            {
                employees.Remove(employees[findEmployee(id)]);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        /// <summary>
        /// Проверка наличия сотрудника с указанным идентификаторов в списке сотрудников,
        /// работающих на предприятии в текущее время.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Наличие сотрудника</returns>
        public bool checkIsEmployee(int id)
        {
            return employees.Exists(emp => emp.Id == id);
        }

        /// <summary>
        /// Создание экземпляра сотрудника по указанному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Сотрудник предприятия</returns>
        private EmployeeFactory createEmployee(int id)
        {
            switch (Database.MyDatabase.selectPositionFromDB(id))
            {
                case "Офис":
                    return new OfficeEmployeeFactory(id);
                case "Производство":
                    return new ProductionEmployeeFactory(id);
                default:
                    return null;
            }
        }
        /// <summary>
        /// Поиск сотрудника с указанным идентификатором в списке.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Индекс сотрудника предприятия</returns>
        private int findEmployee(int id)
        {
            return employees.FindIndex(emp => emp.Id == id);
        }
    }
}
