using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedMetalThickness
{

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class Main : IExternalCommand{
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements){
            Document doc = commandData.Application.ActiveUIDocument.Document;
            List<Element> element = new FilteredElementCollector(doc).WhereElementIsNotElementType().ToList();
            return Result.Succeeded;
        }
    }
}
