using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Основной класс работы с базой данных.
    /// </summary>
    class Database: IDatabase
    {
        /// <summary>
        /// Единственный экземпляр класса работы с базой данных.
        /// </summary>
        static Lazy<Database> myDatabase = new Lazy<Database>(() => new Database());
        /// <summary>
        /// Единственный экземпляр класса работы с базой данных.
        /// </summary>
        public static Database MyDatabase
        {
            get
            {
                return myDatabase.Value;
            }
        }
        /// <summary>
        /// Строка подключения к базе данных.
        /// </summary>
        protected string connectionString;

        /// <summary>
        /// Конструктор, определяющий строку подключения к базе данных.
        /// </summary>
        private Database() 
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C: \\Users\\timos\\OneDrive - ITMO UNIVERSITY\\study\\Master's degree\\01_Проектирование инфокоммуникационных систем\\Домашняя работа\\TimeWorkDB.mdf\";Initial Catalog=TimeWorkDB;Integrated Security=True";
        }

        /// <summary>
        /// Определяет существование сотрудника с указанным идентификаторов в БД предприятия.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Существование сотрудника</returns>
        public bool isEmployeeInDB(int id)
        {
            int[] idEmployees = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (int i in idEmployees)
            {
                if (i == id)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Определение должности, занимаемой сотрудником, по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Должность</returns>
        public string selectPositionFromDB(int id)
        {
            if (id%2 == 0)
            {
                return "Офис";
            }
            return "Производство";
        }
        /// <summary>
        /// Получение данных карты сотрудника по указанному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Список данных о сотруднике.</returns>
        public ArrayList selectCardFromDB(int id)
        {
            ArrayList array = new ArrayList();
            array.Add("Name");
            array.Add("Surname");
            //array.Add("Офис");
            //array.Add("Производство");

            return array;
        }
        /// <summary>
        /// Получение данных о правилах работы для указанной должности.
        /// </summary>
        /// <param name="position">Должность сотрудника.</param>
        /// <returns>Список данных о правилах работы</returns>
        public ArrayList selectWorkRulesFromDB(string position)
        {
            ArrayList array = new ArrayList();
            if (position == "Офис")
            {
                array.Add((double)4);
                array.Add((double)1);
                array.Add((double)8);
            } 
            else if (position == "Производство")
            {
                array.Add((double)5);
                array.Add((double)1.5);
                array.Add((int)6);
                array.Add((int)18);
                array.Add((int)22);
            }
            return array;
        }
        /// <summary>
        /// Отправка данных о рабочем времени офисного сотрудника в базу данных.
        /// </summary>
        /// <param name="work">Данные о рабочем времени</param>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool insertOfficeWorkIntoDB(OfficeWork work, int id)
        {
            Console.WriteLine("Сотрудник №{0} был записан в БД: рабочий день начал в {1}, закончил в {2} " +
                "с общей длительностью работы {3} ч. и перерывом {4} часов. \nНормированные часы: {5}, сверхурочное время: {6}.",
                id, work.TimeLeaving, work.TimeComing, work.GeneralTime, work.BreakTime, work.RationedTime, work.Overtime);
            return true; //запись прошла успешно
            //return false; //запись прошла с ошибкой
        }
        /// <summary>
        /// Отправка данных о рабочем времени производственного сотрудника в базу данных.
        /// </summary>
        /// <param name="work">Данные о рабочем времени</param>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool insertProductionWorkIntoDB(ProductionWork work, int id)
        {
            Console.WriteLine("Сотрудник №{0} был записан в БД: рабочий день начал в {1}, закончил в {2} " +
                "с общей длительностью работы {3} ч. и перерывом {4} часов. \nДневное время работы: {5}, вечернее время работы {6}," +
                "ночное время работы: {7}.", id, work.TimeLeaving, work.TimeComing, work.GeneralTime, work.BreakTime,
                work.DayTime, work.EveningTime, work.NightTime);
            return true; //запись прошла успешно
            //return false; //запись прошла с ошибкой
        }
    }
}
