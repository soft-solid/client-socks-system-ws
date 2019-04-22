using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TestTypeApp.Tools.CustomBindingList
{
    class BindingListWithDeleteDetecting<T> : BindingList<T>
    {
        public event EventHandler<RemoveItemEventArgs> RemovingItem;

        protected virtual void OnRemovingItem(RemoveItemEventArgs args)
        {
            EventHandler<RemoveItemEventArgs> temp = RemovingItem;
            if (temp != null)
            {
                temp(this, args);
            }
        }

        protected override void RemoveItem(int index)
        {
            OnRemovingItem(new RemoveItemEventArgs(this[index]));
            base.RemoveItem(index);
        }

        public BindingListWithDeleteDetecting(IList<T> list) : base(list) {}

        public BindingListWithDeleteDetecting() {}
    }
}
