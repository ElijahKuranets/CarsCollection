using System.ComponentModel;

namespace CarsCollection
{
    public class Product : INotifyPropertyChanged
    {
        private string modelName;
        public string ModelName
        {
            get { return modelName; }
            set
            {
                modelName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ModelName"));
            }
        }

        private decimal engineCapacity;

        public decimal EngineCapacity
        {
            get { return engineCapacity; }
            set
            {
                engineCapacity = value;
                OnPropertyChanged(new PropertyChangedEventArgs("EngineCapacity"));
            }
        }

        public Product(string modelName, int year,
            decimal engineCapacity , string description)
        {
            ModelName = modelName;
            EngineCapacity = engineCapacity;
            Description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }
}
