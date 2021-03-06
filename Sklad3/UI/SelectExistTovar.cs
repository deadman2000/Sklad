﻿using DevExpress.XtraEditors.DXErrorProvider;
using Sklad3.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Sklad3.UI
{
    public partial class SelectExistTovar : UserControl
    {
        public SelectExistTovar()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            BindingSource bsTovar = new BindingSource();
            bsTovar.DataSource = DbSklad.Tovars.FindAll(t => t.TotalCount > 0);
            glueTovar.Properties.DataSource = bsTovar;
            gluevTovar.BestFitColumns();
            gluevTovar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            SetVisibleLabels(false);

            validProvider.SetValidationRule(glueTovar, new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.IsNotBlank,
                ErrorText = "Выберите наименование товара"
            });
            validProvider.SetValidationRule(ceCount, new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.Greater,
                Value1 = 0,
                ErrorText = "Введите количество товаров"
            });
        }

        private List<SklRs> _rsPositions;
        public List<SklRs> RsPositions
        {
            get { return _rsPositions; }
            set { _rsPositions = value; }
        }

        private void SetVisibleLabels(bool visible)
        {
            lcNsch.Visible = visible;
            lcInvn.Visible = visible;
            lcEdism.Visible = visible;
            lcPrice.Visible = visible;
            lcKmCount.Visible = visible;
        }

        private void glueTovar_EditValueChanged(object sender, EventArgs e)
        {
            SetVisibleLabels(glueTovar.EditValue != null);
            var tov = (Tovar)glueTovar.EditValue;
            if (tov != null)
            {
                lcNsch.Text = tov.Nsch;
                lcInvn.Text = tov.Invn;
                lcEdism.Text = tov.EdIsm.Name;
                lcPrice.Text = tov.Price.ToString(CultureInfo.CurrentCulture);
                lcKmCount.Text = GetTotalCount(tov).ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                lcNsch.Text = "";
                lcInvn.Text = "";
                lcEdism.Text = "";
                lcPrice.Text = "";
                lcKmCount.Text = "";
            }
        }

        public double GetTotalCount(Tovar tov)
        {
            if (_rsPositions != null)
                return tov.TotalCount - _rsPositions.FindAll(p => p.Tovar == tov).Sum(p => p.Count);
            return tov.TotalCount;
        }

        private void ceSum_EditValueChanged(object sender, EventArgs e)
        {
            if (SelectedTovar != null)
                ceCount.Value = Math.Round(ceSum.Value / (decimal)SelectedTovar.Price, 4);
            else
                ceCount.Value = 0;
        }

        private void ceCount_EditValueChanged(object sender, EventArgs e)
        {
            if (SelectedTovar != null)
                ceSum.Value = Math.Round(ceCount.Value * (decimal)SelectedTovar.Price, 4);
            else
                ceSum.Value = 0;
        }

        public Tovar SelectedTovar => (Tovar)glueTovar.EditValue;

        public double Count => (double)Math.Round(ceCount.Value, 4);

        public void Clear()
        {
            glueTovar.EditValue = null;
            ceCount.ResetText();
        }
    }
}
