using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Класс рабочего сеанса производственного сотрудника.
    /// </summary>
    class ProductionWork: Work
    {
        /// <summary>
        /// Отработанное дневное время.
        /// </summary>
        private double dayTime;
        /// <summary>
        /// Отработанное дневное время.
        /// </summary>
        public double DayTime
        {
            get
            {
                return dayTime;
            }
        }
        /// <summary>
        /// Отработанное вечернее время.
        /// </summary>
        private double eveningTime;
        /// <summary>
        /// Отработанное вечернее время.
        /// </summary>
        public double EveningTime
        {
            get
            {
                return eveningTime;
            }
        }
        /// <summary>
        /// Отработанное ночное время.
        /// </summary>
        private double nightTime;
        /// <summary>
        /// Отработанное ночное время.
        /// </summary>
        public double NightTime
        {
            get
            {
                return nightTime;
            }
        }

        /// <summary>
        /// Конструктор, задающий время начала работы в качестве текущего.
        /// </summary>
        public ProductionWork(): base()
        { }

        /// <summary>
        /// Рассчет дневного, вечернего и ночного отработанного времени текущего сеанса. 
        /// </summary>
        /// <param name="dayStart">Начало отсчет дневного времени.</param>
        /// <param name="eveningStart">Начало отсчета вечернего времени.</param>
        /// <param name="nightStart">Начало отсчета ночного времени.</param>
        /// <returns>Корректность операции.</returns>
        public override bool calculateDayEveningNightTime(int dayStart, int eveningStart, int nightStart)
        {
            try
            {
                TimeSpan time;
                DateTime point = timeComing;

                if (point < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dayStart, 0, 0))
                {
                    if (timeLeaving <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dayStart, 0, 0))
                    {
                        time = timeLeaving.Subtract(point);
                        nightTime = time.Hours + (time.Minutes / 60);
                        return true;
                    }
                    else
                    {
                        time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dayStart, 0, 0).Subtract(point);
                        nightTime = time.Hours + (time.Minutes / 60);
                        point = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dayStart, 0, 0);
                    }
                }

                if (point < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, eveningStart, 0, 0))
                {
                    if (timeLeaving <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, eveningStart, 0, 0))
                    {
                        time = timeLeaving.Subtract(point);
                        dayTime = time.Hours + (time.Minutes / 60);
                        return true;
                    }
                    else
                    {
                        time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, eveningStart, 0, 0).Subtract(point);
                        dayTime = time.Hours + (time.Minutes / 60);
                        point = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, eveningStart, 0, 0);
                    }
                }

                if (point < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, nightStart, 0, 0))
                {
                    if (timeLeaving <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, nightStart, 0, 0))
                    {
                        time = timeLeaving.Subtract(point);
                        eveningTime = time.Hours + (time.Minutes / 60);
                        return true;
                    }
                    else
                    {
                        time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, nightStart, 0, 0).Subtract(point);
                        eveningTime = time.Hours + (time.Minutes / 60);
                        point = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, nightStart, 0, 0);
                    }
                }

                if (point < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1))
                {
                    if (timeLeaving <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1))
                    {
                        time = timeLeaving.Subtract(point);
                        nightTime += time.Hours + (time.Minutes / 60);
                        return true;
                    }
                    else
                    {
                        time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).Subtract(point);
                        nightTime += time.Hours + (time.Minutes / 60);
                    }
                }

                return false;
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
        public override bool setWorkDB(int id)
        {
            return ProxyDatabase.MyProxyDatabase.insertProductionWorkIntoDB(this, id);
        }
    }
}
