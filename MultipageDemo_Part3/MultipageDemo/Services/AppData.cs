using System;
namespace MultipageDemo.Services
{
    public class AppData
    {
        public int currentCount { get; set; }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                NotifyDataChanged();
            }
        }

        public event Action OnChange;

        private void NotifyDataChanged() => OnChange?.Invoke();
    }
}

