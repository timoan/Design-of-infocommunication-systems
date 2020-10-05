using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Карты производственных сотрудников предприятия и данные с них.
    /// </summary>
    class ProductionCard : Card
    {
        /// <summary>
        /// Конструктор, заполняющий все поля класса из базы данных согласно идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        public ProductionCard(int id): base(id)
        {
            position = "Производство";
        }
    }
}
