using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    /// <summary>
    /// Общие правила работы сотрудников на предприятии.
    /// </summary>
    abstract class WorkRules
    {
        /// <summary>
        /// Регулярность перерыва - в часах.
        /// </summary>
        protected double breakRegularity;
        /// <summary>
        /// Регулярность перерыва.
        /// </summary>
        public double BreakRegularity
        {
            get
            {
                return breakRegularity;
            }
        }
        /// <summary>
        /// Длительность перерыва - в часах.
        /// </summary>
        protected double breakDuration;
        /// <summary>
        /// Длительность перерыва.
        /// </summary>
        public double BreakDuration
        {
            get
            {
                return breakDuration;
            }
        }

        /// <summary>
        /// Начало отсчета дневных часов.
        /// </summary>
        protected int dayStart;
        /// <summary>
        /// Начало отсчета дневных часов.
        /// </summary>
        public int DayStart
        {
            get
            {
                return dayStart;
            }
        }
        /// <summary>
        /// Начало отсчета вечерних часов.
        /// </summary>
        protected int eveningStart;
        /// <summary>
        /// Начало отсчета вечерних часов.
        /// </summary>
        public int EveningStart
        {
            get
            {
                return eveningStart;
            }
        }
        /// <summary>
        /// Начало отсчета ночных часов.
        /// </summary>
        protected int nightStart;
        /// <summary>
        /// Начало отсчета ночных часов.
        /// </summary>
        public int NightStart
        {
            get
            {
                return nightStart;
            }
        }

        /// <summary>
        /// Норма выработки: нормированное количество часов в сутки.
        /// </summary>
        protected double workRate;
        /// <summary>
        /// Норма выработки - часов/день.
        /// </summary>
        public double WorkRate
        {
            get
            {
                return workRate;
            }
        }

        /// <summary>
        /// Конструктор, инициализирующий экземпляр класса.
        /// </summary>
        public WorkRules(string position) { }
        
    }
}
