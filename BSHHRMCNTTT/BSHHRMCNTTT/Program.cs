using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Threading;
using System.Globalization;


namespace BSHHRMCNTTT
{
    static class Program
    {
    

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi");
            var culture = new CultureInfo("vi-VN", true)
            {
                DateTimeFormat ={
                    ShortDatePattern="dd/MM/yyyy", ShortTimePattern="HH:mm:ss"


            }

            };
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
           
            SkinManager.EnableMdiFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("Summer");
            UserLookAndFeel.Default.SkinName = "Caramel";
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Tahoma", 9);

            //Application.Run(new SysForm.frmConnectDB());
            SO.DBConnection.InforConnect("127.0.0.1,1433", "BSHHRM", "admin", "admin");
            SO.DBConnection.OpenConnection();
            Application.Run(new GUI.BSH_TonGiao());

        }
    }
}
