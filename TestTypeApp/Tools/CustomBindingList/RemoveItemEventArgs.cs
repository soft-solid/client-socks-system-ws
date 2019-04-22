using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Tools.CustomBindingList
{
    public class RemoveItemEventArgs : EventArgs
    {
        public object RemovedItem { get; private set; }

        public RemoveItemEventArgs(object removedItem)
        {
            this.RemovedItem = removedItem;
        }
    }
}
