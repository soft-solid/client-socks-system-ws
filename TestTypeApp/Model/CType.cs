using System;
using System.ComponentModel;
using TestTypeApp.Client;
using TestTypeApp.TypeService;
using TestTypeApp.Tools.Loggers;
using TestTypeApp.Tools.ExtensionMethods;

namespace TestTypeApp.Model
{
   public class CType : Transportable<socksType>, INotifyPropertyChanged 
    {
        public CType() : base(new socksType())
        {
            Active = true;
        }

        public CType(socksType type) : base(type) {}

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
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));//"nameof(this.Name)" - using C# 6.0
                }
                else
                {
                    CTypeLogger.Instance.Error(this);
                    throw new NullReferenceException("There is no subscribers!");
                }
            }
        }
   
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
