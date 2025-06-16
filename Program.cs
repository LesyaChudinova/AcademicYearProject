using OfficeOpenXml;
using System;
using System.Windows.Forms;

namespace AcademicYearProject
{
    static class Program
    {
        [STAThread]

        static void Main()
        {
            ExcelPackage.License.SetNonCommercialOrganization("некоммерческое использование");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
