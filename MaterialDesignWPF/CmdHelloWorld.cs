using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NameSpaces
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;

namespace MaterialDesignWPF
{
    [Transaction(TransactionMode.Manual)]
    class CmdHelloWorld : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
                              ref string message,
                              ElementSet elements)
        {
            NewWindow window = new NewWindow();
            window.Show();

            return Result.Succeeded;

        }
    }
}
