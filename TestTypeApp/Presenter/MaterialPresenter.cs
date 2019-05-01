﻿using System;
using System.Linq;
using TestTypeApp.Model;
using TestTypeApp.Model.Repository;
using TestTypeApp.View;

namespace TestTypeApp.Presenter
{
    class MaterialPresenter :IPresenter
    {
        private IBaseRepositoryModel<CMaterial> _repositoryModel;
        private IItemView<CMaterial> _view;
        private int _currentID;

        public MaterialPresenter(IBaseRepositoryModel<CMaterial> repositoryModel, IItemView<CMaterial> view)
        {
            this._repositoryModel = repositoryModel;
            this._view = view;
            repositoryModel.Reload();
            view.ItemList = repositoryModel.ItemList;
            _currentID = repositoryModel.ItemList.First().Id;
            view.CurrentItem = repositoryModel.ItemList.First();
            view.RefreshView += ViewRefreshView;
            view.Save += view_Save;
            view.AddNew += view_AddNew;
            view.Show();
        }

        void view_AddNew(object sender, EventArgs e)
        {
            _view.CurrentItem = _repositoryModel.CreateNew();
        }

        void view_Save(object sender, EventArgs e)
        {
            _repositoryModel.Save();
        }

        void ViewRefreshView(object sender, EventArgs e)
        {
            _currentID = _view.CurrentItem.Id;
            _repositoryModel.Reload();
            _view.CurrentItem = _repositoryModel.ItemList.FirstOrDefault(n => n.Id == _currentID);
        }
    }
}
