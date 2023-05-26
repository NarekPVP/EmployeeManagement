using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Services
{
    public class PrinterService : IPrinterService
    {
        public PrintDialog Dialog { get; set; }

        public PrinterService(PrintDialog dialog)
        {
            Dialog = dialog;
        }

        public void InitializePrinter()
        {
            // Allow the user to choose the page range he or she would
            // like to print.
            Dialog.AllowSomePages = true;

            // Show the help button.
            Dialog.ShowHelp = true;
        }

        public bool PrintResult()
        {
            DialogResult printResult = Dialog.ShowDialog();

            if(printResult == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(Settings.EmployeeFilePath))
                {
                    PrintDocument printDocument = new PrintDocument();

                    printDocument.PrintPage += (s, pe) =>
                    {
                        string line = reader.ReadLine();

                        pe.Graphics.DrawString(
                            s: line,
                            font: new Font("Arial", 12),
                            Brushes.Black,
                            pe.MarginBounds.Left,
                            pe.MarginBounds.Top);

                        if (!reader.EndOfStream)
                            pe.HasMorePages = true;
                    };

                    // Set the PrintDocument to use the selected printer
                    printDocument.PrinterSettings = Dialog.PrinterSettings;

                    // Start the printing process
                    printDocument.Print();
                }

                return true;
            }

            return false;
        }
    }
}
