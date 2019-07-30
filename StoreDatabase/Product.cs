using System.ComponentModel;

namespace CarsCollection
{
    public class Product : INotifyPropertyChanged
    {
        private string modelName;
        public string ModelName
        {
            get => modelName;
            set
            {
                modelName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ModelName"));
            }
        }

        private string year;
        public string Year
        {
            get => year;
            set
            {
                year = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Year"));
            }
        }

        private string engineCapacity;

        public string EngineCapacity
        {
            get => engineCapacity;
            set
            {
                engineCapacity = value;
                OnPropertyChanged(new PropertyChangedEventArgs("EngineCapacity"));
            }
        }

        private string description;
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Description"));
            }
        }
        public Product(string modelName, string year,
            string engineCapacity , string description)
        {
            ModelName = modelName;
            Year = year;
            EngineCapacity = engineCapacity;
            Description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
