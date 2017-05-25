using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using Sklad3.UI;

namespace Sklad3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BarAndDockingController.Default.AppearancesBar.Bar.Font = new Font("Courier", 40, FontStyle.Bold);
            AppearanceObject.DefaultFont = new Font("Tahoma", 10, FontStyle.Regular);

            try
            {
                DbSklad.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Init DB error: " + ex);
                return;
            }
            
            //Importer.Import(@"D:\Work\Склад\Склад2\Sklad.gdb");
            Application.Run(new MainForm());
        }
    }
}
