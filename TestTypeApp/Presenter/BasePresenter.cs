using System;

namespace TestTypeApp.Presenter
{
    class BasePresenter : IPresenter
    {
        public void ViewClosed(object sender, EventArgs e)
        {
            if (FormClosing != null)
                FormClosing(this, EventArgs.Empty);
        }

        public event EventHandler<EventArgs> FormClosing;
    }
}
