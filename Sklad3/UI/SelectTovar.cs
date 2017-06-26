using DevExpress.XtraEditors.DXErrorProvider;
using Sklad3.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Sklad3.UI
{
    public partial class SelectTovar : UserControl
    {
        public SelectTovar()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            BindingSource bsTovar = new BindingSource();
            bsTovar.DataSource = DbSklad.Tovars;
            glueTovar.Properties.DataSource = bsTovar;
            gluevTovar.BestFitColumns();
            gluevTovar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;

            SetVisibleLabels(false);

            cbName.Properties.Items.AddRange(DbSklad.TovNamesList()); cbNsch.Properties.Items.AddRange(DbSklad.NschList());
            cbEdism.Properties.Items.AddRange(DbSklad.EdIsm);

            plNewTov.Visible = false;

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
            validProvider.SetValidationRule(cbName, new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.IsNotBlank,
                ErrorText = "Введите наименование товара"
            });
            validProvider.SetValidationRule(cbNsch, new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.IsNotBlank,
                ErrorText = "Введите номер счета"
            });
            validProvider.SetValidationRule(cbEdism, new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.IsNotBlank,
                ErrorText = "Введите единицу измерения"
            });
        }

        private List<SklRs> _rsPositions;
        public List<SklRs> RsPositions
        {
            get { return _rsPositions; }
            set { _rsPositions = value; }
        }

        private bool _useCount = true;
        public bool UseCount
        {
            get { return _useCount; }
            set
            {
                _useCount = value;
                lcCount.Visible = value;
                ceCount.Visible = value;
                lcSum.Visible = value;
                ceSum.Visible = value;
                lcKmCount.Visible = value;
                lcKmCountTitle.Visible = value;
            }
        }

        void SetVisibleLabels(bool visible)
        {
            lcNsch.Visible = visible;
            lcInvn.Visible = visible;
            lcEdism.Visible = visible;
            lcPrice.Visible = visible;
            lcKmCount.Visible = visible;
        }

        private void chbNewTovar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNewTovar.Checked)
            {
                cbName.Text = glueTovar.Text;
                plExistTov.Visible = false;
                plNewTov.Visible = true;
                cbName.Focus();
            }
            else
            {
                plNewTov.Visible = false;
                plExistTov.Visible = true;
                glueTovar.Focus();
            }
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
            if (chbNewTovar.Checked)
            {
                if (ceCount.Value != 0)
                    cePrice.Value = Math.Round(ceSum.Value / ceCount.Value, 4);
            }
            else
            {
                if (lcPrice.Visible)
                    ceCount.Value = Math.Round(ceSum.Value / decimal.Parse(lcPrice.Text), 4);
            }
        }

        private void ceCount_EditValueChanged(object sender, EventArgs e)
        {
            if (chbNewTovar.Checked)
                ceSum.Value = Math.Round(ceCount.Value * cePrice.Value, 4);
            else
            {
                if (lcPrice.Visible)
                    ceSum.Value = Math.Round(ceCount.Value * decimal.Parse(lcPrice.Text), 4);
            }
        }

        private void cePrice_EditValueChanged(object sender, EventArgs e)
        {
            if (ceCount.Value != 0)
                ceSum.Value = Math.Round(cePrice.Value * ceCount.Value, 4);
        }


        private Tovar _created;

        public Tovar SelectedTovar
        {
            get
            {
                if (!validProvider.Validate())
                    return null;

                if (chbNewTovar.Checked)
                {
                    if (_created != null) return _created;

                    EdIsm edIsm = (cbEdism.SelectedItem as EdIsm) ?? DbSklad.AddEdIsm(cbEdism.Text);
                    return _created = DbSklad.AddTovar(cbName.Text, edIsm, (double)cePrice.Value, teInvn.Text, cbNsch.Text);
                }

                return (Tovar)glueTovar.EditValue;
            }
        }

        public double Count => (double)Math.Round(ceCount.Value, 4);

        public void Clear()
        {
            glueTovar.EditValue = null;
            cbName.ResetText();
            cbNsch.ResetText();
            teInvn.ResetText();
            cbEdism.ResetText();
            cePrice.ResetText();
            ceCount.ResetText();
        }
    }
}
