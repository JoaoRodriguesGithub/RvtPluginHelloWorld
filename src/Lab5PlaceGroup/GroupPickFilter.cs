using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace Lab5PlaceGroup
{
    // Filter to constrain picking to model groups. Only model groups
    // are highlighted and can be selected when cursor is hovering.
    public class GroupPickFilter : ISelectionFilter
    {
        public bool AllowElement(Element e)
        {
            return (e.Category.Id.IntegerValue.Equals((int)BuiltInCategory.OST_IOSModelGroups));
        }
        public bool AllowReference(Reference r, XYZ p)
        {
            return false;
        }
    }
}