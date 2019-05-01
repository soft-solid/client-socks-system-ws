using System;

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
