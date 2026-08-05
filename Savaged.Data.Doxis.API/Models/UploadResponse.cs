namespace Savaged.Data.Doxis.API.Models;

public record UploadResponse(string result, string request_id, Document data) : IResponseModel;

