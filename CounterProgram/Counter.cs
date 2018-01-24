using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CounterProgram
{
    public class Counter : INotifyPropertyChanged
    {
        private int count = 0;

        

        #region Counter accesors
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
                RaisePropertyChanged(new PropertyChangedEventArgs("Count"));
            }
        }

        public void IncrementCount()
        {
            this.count++;
        }

        public void DecrementCount()
        {
            if (count > 0)
            {
                this.count--;
            }
        }
        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void RaisePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        #endregion

        public enum FoodType
        {
            Meat = 0,
            Fruit = 1,
            Vegetable = 2,
            Other = 3
        }

        List<FoodType> foodItems = new List<FoodType>();

}
}
