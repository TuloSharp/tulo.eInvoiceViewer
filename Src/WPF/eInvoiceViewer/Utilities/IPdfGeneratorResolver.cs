using tulo.CoreLib.Components.ResultPattern;
using tulo.XMLeInvoiceToPdf.Services;

namespace tulo.eInvoiceViewer.Utilities;
public interface IPdfGeneratorResolver
{
    Result<IPdfGeneratorFromInvoice> ResolveByName(string name);
}
