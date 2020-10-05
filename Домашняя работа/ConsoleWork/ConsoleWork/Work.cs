using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Абстрактный класс рабочего сеанса сотрудника.
    /// </summary>
    abstract class Work
    {
        /// <summary>
        /// Время начала работы.
        /// </summary>
        protected DateTime timeComing;
        /// <summary>
        /// Время начала работы.
        /// </summary>
        public DateTime TimeComing
        {
            get
            {
                return timeComing;
            }
        }
        /// <summary>
        /// Время окончания работы.
        /// </summary>
        protected DateTime timeLeaving;
        /// <summary>
        /// Время окончания работы.
        /// </summary>
        public DateTime TimeLeaving
        {
            get
            {
                return timeLeaving;
            }
            set
            {
                timeLeaving = value;
            }
        }
        /// <summary>
        /// Рассчитанное общее время работы.
        /// </summary>
        protected double generalTime;
        /// <summary>
        /// Рассчитанное общее время работы.
        /// </summary>
        public double GeneralTime
        {
            get
            {
                return generalTime;
            }
        }
        /// <summary>
        /// Рассчитанное общее время перерывов.
        /// </summary>
        protected double breakTime;
        /// <summary>
        /// Рассчитанное общее время перерывов.
        /// </summary>
        public double BreakTime
        {
            get
            {
                return breakTime;
            }
        }

        /// <summary>
        /// Конструктор, задающий время начала работы в качестве текущего.
        /// </summary>
        public Work()
        {
            timeComing = DateTime.Now;
        }

        /// <summary>
        /// Рассчет общих параметров рабочего времени (общего времени работы и времени перерыва).
        /// </summary>
        /// <param name="breakRegulary">Регулярность перерыва.</param>
        /// <param name="breakDuration">Длительность перерыва.</param>
        /// <returns>Корректность операции.</returns>
        public bool calculateGeneralTime(double breakRegulary, double breakDuration)
        {
            try
            {
                TimeSpan allTime = timeLeaving.Subtract(timeComing);
                double allHours = allTime.Hours + (allTime.Minutes / 60);

                breakTime = Math.Truncate(allHours / breakRegulary) * breakDuration;
                generalTime = allHours - breakTime;

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Рассчет дневного, вечернего и ночного отработанного времени текущего сеанса. 
        /// </summary>
        /// <param name="dayStart">Начало отсчет дневного времени.</param>
        /// <param name="eveningStart">Начало отсчета вечернего времени.</param>
        /// <param name="nightStart">Начало отсчета ночного времени.</param>
        /// <returns>Корректность операции.</returns>
        public virtual bool calculateDayEveningNightTime(int dayStart, int eveningStart, int nightStart)
        {
            return true;
        }
        /// <summary>
        /// Рассчет нормированного и сверхурочного отработанного времени текущего временного сеанса.
        /// </summary>
        /// <param name="workRate">Норма выработки</param>
        /// <returns>Корректность операции</returns>
        public virtual bool calculateRateOverTime(double workRate)
        {
            return true;
        }

        /// <summary>
        /// Сохранение данных о рабочем сеансе путем отправки их в БД.
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Корректность операции</returns>
        abstract public bool setWorkDB(int id);
    }
}
