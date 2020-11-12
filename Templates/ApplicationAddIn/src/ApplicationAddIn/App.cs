using System.Diagnostics.CodeAnalysis;
using Autodesk.Revit.UI;

namespace ApplicationAddIn {
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
