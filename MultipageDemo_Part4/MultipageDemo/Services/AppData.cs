using System;
using System.Collections.Generic;

namespace MultipageDemo.Services
{
    public class AppData
    {
        public List<int> playerScores = new List<int>();
        public int currentPlayer = 0;

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

