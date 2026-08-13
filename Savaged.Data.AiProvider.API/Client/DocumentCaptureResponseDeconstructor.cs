using Newtonsoft.Json;
using Savaged.Data.AiProvider.API.Interfaces;
using Savaged.Data.AiProvider.API.Models;
using Savaged.Core.Extensions;

namespace Savaged.Data.AiProvider.API.Client;

public class DocumentCaptureResponseDeconstructor : IResponseDeconstructor
{
    public object Deconstruct(string response)
    {
        var root = JsonConvert.DeserializeObject<Root>(response);
        var invoiceNumber = root.data.components.financial.invoice_number;
        // TODO extract all specified fields
        return invoiceNumber;
    }
}
