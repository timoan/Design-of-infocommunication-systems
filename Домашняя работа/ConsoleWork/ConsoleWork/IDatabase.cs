using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Интерфейс, определяющий методы работы с базой данных.
    /// </summary>
    interface IDatabase
    {
        /// <summary>
        ///  Проверка существования сотрудника с указанным идентификатором в базе данных.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Результат проверки.</returns>
        bool isEmployeeInDB(int id);
        /// <summary>
        /// Определение должности, занимаемой сотрудником, по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Должность</returns>
        string selectPositionFromDB(int id);
        /// <summary>
        /// Получение данных карты сотрудника по указанному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Список данных о сотруднике.</returns>
        ArrayList selectCardFromDB(int id);
        /// <summary>
        /// Получение данных о правилах работы для указанной должности.
        /// </summary>
        /// <param name="position">Должность сотрудника.</param>
        /// <returns>Список данных о правилах работы</returns>
        ArrayList selectWorkRulesFromDB(string position);
        /// <summary>
        /// Отправка данных о рабочем времени офисного сотрудника в базу данных.
        /// </summary>
        /// <param name="work">Данные о рабочем времени</param>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        bool insertOfficeWorkIntoDB(OfficeWork work, int id);
        /// <summary>
        /// Отправка данных о рабочем времени производственного сотрудника в базу данных.
        /// </summary>
        /// <param name="work">Данные о рабочем времени</param>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        bool insertProductionWorkIntoDB(ProductionWork work, int id);
    }
}
