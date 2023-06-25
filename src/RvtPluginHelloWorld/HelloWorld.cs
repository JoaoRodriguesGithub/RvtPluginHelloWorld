using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RvtPluginHelloWorld
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class HelloWorld : IExternalCommand
    {
        public Result Execute(ExternalCommandData revit,
           ref string message, ElementSet elements)
        {
            TaskDialog.Show("Revit", "Hello World");
            return Result.Succeeded;
        }
    }
}