using System;

namespace TestTypeApp.Presenter
{
    public interface IPresenter
    {
        event EventHandler<EventArgs> FormClosing;
    }
}
