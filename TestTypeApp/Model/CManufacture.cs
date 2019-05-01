using System;
using System.ComponentModel;
using TestTypeApp.Client;
using TestTypeApp.ManufactureService;
using TestTypeApp.Tools.Loggers;

namespace TestTypeApp.Model
{
    public class CManufacture : Transportable<manufacture>, INotifyPropertyChanged 
    {
        public CManufacture()
            : base(new manufacture())
        {
            Active = true;
        }

        public CManufacture(manufacture manufacture) : base(manufacture) { }

        public int Id
        {
            get { return dto.id; }
            set { dto.id = value; }
        }

        public bool Active
        {
            get { return dto.active; }
            set { dto.active = value; }
        }

        public string Name
        {
            get { return dto.name; }
            set
            {
                dto.name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
                else
                {
                    CManufactureLogger.Instance.Error(this);
                    throw new NullReferenceException("There is no subscribers!");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
