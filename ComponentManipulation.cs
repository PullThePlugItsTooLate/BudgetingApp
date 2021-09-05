using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: PROG6212
/// Task: Task1
/// Semester: 2
/// </summary>

namespace BudgetingApp
{
    class ComponentManipulation
    {
        public static List<Form> lstInstanceForm = new List<Form>();//Keeps tracks of the forms that are open and closes them accordingly

        public static void FormTransitions(Form frmMain, Form frmInstance)
        {//used whenever the user is going from the main form to an external form
            frmInstance.Tag = frmMain;// the tag property stores the current instance of main form and calls it when the user taps the back button instead of creating an form
            frmInstance.Show(frmMain);//shows the instance and passes the main form as an argument
            frmMain.Hide();//hides the form
        }

        public static void ClickCurrect(Panel pnlNav, Button btn)//changes the buttons and panels properties for visual appeal
        {
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        public static void LeaveCurrent(Button btn)//When the component is left on the leave event change its color
        {
            btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//importing a dll, makes forms rounded at the edges
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);//use dll method to make form rounded

        public static string GetCurrentDate()//gets the current date
        {
            DateTime d = DateTime.UtcNow.Date;
            return d.ToString("d");
        }

        public static void ClearFormInstance()//takes whatever forms are in the forms lst and closes it
        {
            if (lstInstanceForm.Count == 1)
            {
                foreach (Form formInstance in lstInstanceForm)
                {
                    formInstance.Close();
                }
            }
        }
    }
}
