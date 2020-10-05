using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Заместитель класса работы с базой данных.
    /// </summary>
    class ProxyDatabase: IDatabase
    {
        /// <summary>
        /// Работа с базой данных.
        /// </summary>
        Database database;
        /// <summary>
        /// Единственный экземпляр заместителя класса работы с базой данных.
        /// </summary>
        static Lazy<ProxyDatabase> myProxyDatabase = new Lazy<ProxyDatabase>(() => new ProxyDatabase());
        /// <summary>
        /// Единственный экземпляр заместителя класса работы с базой данных.
        /// </summary>
        public static ProxyDatabase MyProxyDatabase
        {
            get
            {
                return myProxyDatabase.Value;
            }
        }

        /// <summary>
        /// Конструктор, определяющий экземпляр класса для работы с базой данных.
        /// </summary>
        private ProxyDatabase()
        {
            database = Database.MyDatabase;
        }

        /// <summary>
        ///  Проверка существования сотрудника с указанным идентификатором в базе данных.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Результат проверки.</returns>
        public bool isEmployeeInDB(int id)
        {
            //тут может быть второстепенный код или проверка
            return database.isEmployeeInDB(id);
        }
        /// <summary>
        /// Определение должности, занимаемой сотрудником, по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Должность</returns>
        public string selectPositionFromDB(int id)
        {
            return database.selectPositionFromDB(id);
        }
        /// <summary>
        /// Получение данных карты сотрудника по указанному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Список данных о сотруднике.</returns>
        public ArrayList selectCardFromDB(int id)
        {
            //тут может быть второстепенный код или проверка
            return database.selectCardFromDB(id);
        }
        /// <summary>
        /// Получение данных о правилах работы для указанной должности.
        /// </summary>
        /// <param name="position">Должность сотрудника.</param>
        /// <returns>Список данных о правилах работы</returns>
        public ArrayList selectWorkRulesFromDB(string position)
        {
            //тут может быть второстепенный код или проврека
            return database.selectWorkRulesFromDB(position);
        }
        /// <summary>
        /// Отправка данных о рабочем времени офисного сотрудника в базу данных.
        /// </summary>
        /// <param name="work">Данные о рабочем времени</param>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool insertOfficeWorkIntoDB(OfficeWork work, int id)
        {
            //тут может быть второстепенный код или проверка
            return database.insertOfficeWorkIntoDB(work, id);
        }
        /// <summary>
        /// Отправка данных о рабочем времени производственного сотрудника в базу данных.
        /// </summary>
        /// <param name="work">Данные о рабочем времени</param>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        public bool insertProductionWorkIntoDB(ProductionWork work, int id)
        {
            return database.insertProductionWorkIntoDB(work, id);
        }
    }
}
