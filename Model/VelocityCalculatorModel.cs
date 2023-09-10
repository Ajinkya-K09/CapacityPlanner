using System;
using System.ComponentModel;

namespace VelocityCalculator.Model
{
    public class VelocityCalculatorModel : INotifyPropertyChanged
    {
        private int m_numberOfMembers;
        private int m_comapanyHolidays;
        private int m_totalLeaves;
        private int m_sprintWeekDuration;
        private bool m_isSatSunOff;

        public int NumberOfMembers
        {
            get
            {
                return m_numberOfMembers;
            }
            set
            {
                m_numberOfMembers = value;
                CalculateTotalWorkingDays();
            }
        }

        public int CompnayHolidays
        {
            get
            {
                return m_comapanyHolidays;
            }
            set
            {
                m_comapanyHolidays = value;
                CalculateTotalWorkingDays();
            }
        }

        public int TotalLeaves
        {
            get
            {
                return m_totalLeaves;
            }
            set
            {
                m_totalLeaves = value;
                CalculateTotalWorkingDays();
            }
        }

        public int SprintWeeks
        {
            get
            {
                return m_sprintWeekDuration;
            }
            set
            {
                if (value > 0)
                {
                    m_sprintWeekDuration = value;
                    CalculateTotalWorkingDays();
                }
            }
        }


        public int TotalWorkingDays { get; set; }

        public bool IsSatSunOff
        {
            get
            {
                return m_isSatSunOff;
            }
            set
            {
                m_isSatSunOff = value;
                CalculateTotalWorkingDays();
            }
        }

        public double TotalEstimatedCapacityPercentage { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void CalculateTotalWorkingDays()
        {
            if (SprintWeeks > 0)
            {
                var totalSprintDays = (SprintWeeks * 7) - CompnayHolidays;
                totalSprintDays = IsSatSunOff ? totalSprintDays -= (SprintWeeks * 2) : totalSprintDays;
                totalSprintDays *= NumberOfMembers;
                TotalWorkingDays = totalSprintDays;
                RaisePropertyChanged(nameof(TotalWorkingDays));
                CalculateTotalCapacity();
            }
        }

        private void CalculateTotalCapacity()
        {
            var estimatedCapacity = ((double)(TotalWorkingDays - TotalLeaves) / TotalWorkingDays);
            TotalEstimatedCapacityPercentage = Math.Ceiling(estimatedCapacity * 100.00);
            RaisePropertyChanged(nameof(TotalEstimatedCapacityPercentage));
        }
    }
}
