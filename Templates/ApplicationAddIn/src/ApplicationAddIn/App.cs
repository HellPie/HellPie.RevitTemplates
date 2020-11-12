using System.Diagnostics.CodeAnalysis;
using Autodesk.Revit.UI;

namespace HellPie.RevitTemplates.Templates.ApplicationAddIn.src.ApplicationAddIn {
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    internal class App : IExternalApplication {
        /// <inheritdoc />
        public Result OnStartup(UIControlledApplication application) {
            return Result.Succeeded;
        }

        /// <inheritdoc />
        public Result OnShutdown(UIControlledApplication application) {
            return Result.Succeeded;
        }
    }
}
