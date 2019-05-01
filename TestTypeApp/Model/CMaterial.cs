using System;
using System.ComponentModel;
using TestTypeApp.Client;
using TestTypeApp.MaterialService;
using TestTypeApp.Tools.Loggers;


namespace TestTypeApp.Model
{
    public class CMaterial : Transportable<material>, INotifyPropertyChanged
    {
        public CMaterial()
            : base(new material())
        {
            Active = true;
        }

        public CMaterial(material material) : base(material) { }

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
                    CMaterialLogger.Instance.Error(this);
                    throw new NullReferenceException("There is no subscribers!");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
