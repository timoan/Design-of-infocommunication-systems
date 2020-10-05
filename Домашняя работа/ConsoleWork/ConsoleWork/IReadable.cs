using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Интерфейс для работы пользователя системы, обеспечивающий считывание данных с карты.
    /// </summary>
    interface IReadable
    {
        /// <summary>
        /// Производит обработку прикладывания карты пользователя.
        /// </summary>
        /// <param name="id">Уникальный идентификатор пользователя, полученный при считывании карты</param>
        /// <returns>Возвращает корректность выполнения операции</returns>
        bool fixGo(string id);
    }
}
