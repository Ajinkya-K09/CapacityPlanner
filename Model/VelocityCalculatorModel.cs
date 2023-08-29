using System.ComponentModel;

namespace VelocityCalculator.Model
{
    public class VelocityCalculatorModel : INotifyPropertyChanged
    {
        private int m_numberOfMembers;
        private int m_comapanyHolidays;
        private int m_totalLeaves;
        private int m_totalSprintDays;

        public int NumberOfMembers
        {
            get
            {
                return m_numberOfMembers;
            }
            set
            {
                m_numberOfMembers = value;
            }
        }

        public int CompnayHolidays
        {
            get
            {
                return m_numberOfMembers;
            }
            set
            {
                m_numberOfMembers = value;
            }
        }

        public int TotalLeaves
        {
            get
            {
                return m_numberOfMembers;
            }
            set
            {
                m_numberOfMembers = value;
            }
        }

        public int TotalSprintDays
        {
            get
            {
                return m_numberOfMembers;
            }
            set
            {
                m_numberOfMembers = value;
            }
        }

        public int TotalWorkingDays { get; set; }

        public bool IsSatSunOff { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
