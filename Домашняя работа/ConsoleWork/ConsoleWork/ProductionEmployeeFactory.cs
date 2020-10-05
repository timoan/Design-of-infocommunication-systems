using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Фабрика производственных сотрудников.
    /// </summary>
    class ProductionEmployeeFactory: EmployeeFactory
    {
        /// <summary>
        /// Конструктор, заполняющий поля класса с помощью использования фабричный методов.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        public ProductionEmployeeFactory(int id) : base(id)
        { }

        /// <summary>
        /// Производит рассчет параметров рабочего сеанса производственного сотрудника, заполняя поля класса.
        /// </summary>
        /// <returns>Корректность операции</returns>
        protected override bool calculatedWork()
        {
            try
            {
                if (base.calculatedWork() && 
                    work.calculateDayEveningNightTime(workRules.DayStart, workRules.EveningStart, workRules.NightStart))
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
        /// Фабричный метод для создания карты сотрудника.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Карта сотрудника</returns>
        protected override Card createCard(int id)
        {
            return new ProductionCard(id);
        }
        /// <summary>
        /// Фабричный метод для создания рабочей сессии сотрудника.
        /// </summary>
        /// <returns>Рабочая сессия</returns>
        protected override Work createWork()
        {
            return new ProductionWork();
        }
        /// <summary>
        /// Фабричный метод для создания правил работы сотрудника.
        /// </summary>
        /// <returns>Правила работы</returns>
        protected override WorkRules createWorkRules(string position)
        {
            return new ProductionWorkRules(position);
        }

    }
}
