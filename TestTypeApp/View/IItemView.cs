﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Commands;

namespace TestTypeApp.View
{
    interface IItemView<TClientType> 
    {
        Form MdiParent { get; set; }
        event EventHandler<EventArgs> RefreshView;
        event EventHandler<EventArgs> Save;
        event EventHandler<EventArgs> AddNew;

        IList<TClientType> ItemList { set; }
        TClientType CurrentItem { get; set; }

        void Show();
    }
}