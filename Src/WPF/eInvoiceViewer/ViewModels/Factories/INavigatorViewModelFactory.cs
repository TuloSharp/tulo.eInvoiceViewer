using tulo.CommonMVVM.ViewModels;
using tulo.eInvoiceViewer.Utilities;

namespace tulo.eInvoiceViewer.ViewModels.Factories
{
    public interface INavigatorViewModelFactory
    {
        /// <summary>
        /// a selected view model is created
        /// </summary>
        /// <param name="viewTypes">the view model type is in an enum defined</param>
        /// <returns>the created view model</returns>
        BaseViewModel CreateViewModel(NavTypes viewTypes);
    }
}
