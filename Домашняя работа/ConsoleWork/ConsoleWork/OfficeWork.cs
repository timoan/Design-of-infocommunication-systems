using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Рабочий сеанс офисного сотрудника.
    /// </summary>
    class OfficeWork: Work
    {
        /// <summary>
        /// Нормированное отработанное время.
        /// </summary>
        private double rationedTime;
        /// <summary>
        /// Нормированное отработанное время.
        /// </summary>
        public double RationedTime
        {
            get
            {
                return rationedTime;
            }
        }
        /// <summary>
        /// Сверхурочное отработанное время.
        /// </summary>
        private double overtime;
        /// <summary>
        /// Сверхурочное отработанное время.
        /// </summary>
        public double Overtime
        {
            get
            {
                return overtime;
            }
        }

        /// <summary>
        /// Конструктор, задающий время начала работы в качестве текущего.
        /// </summary>
        public OfficeWork():base()
        { }

        /// <summary>
        /// Рассчет нормированного и сверхурочного отработанного времени текущего временного сеанса.
        /// </summary>
        /// <param name="workRate">Норма выработки</param>
        /// <returns>Корректность операции</returns>
        public override bool calculateRateOverTime(double workRate)
        {
            try
            {
                if (generalTime > workRate)
                {
                    rationedTime = workRate;
                    overtime = generalTime - rationedTime;
                }
                else
                {
                    rationedTime = generalTime;
                } 
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Сохранение данных о рабочем сеансе путем отправки их в БД.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        override public bool setWorkDB(int id)
        {
            return ProxyDatabase.MyProxyDatabase.insertOfficeWorkIntoDB(this, id);
        }
    }
}
