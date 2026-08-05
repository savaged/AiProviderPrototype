using Savaged.Data.Doxis.API.Interfaces;

namespace Savaged.Data.Doxis.API.Models;

public record UploadResponse(string result, string request_id, string data) : IResponseModel;
