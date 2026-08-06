using Savaged.Data.AiProvider.API.Interfaces;

namespace Savaged.Data.AiProvider.API.Models;

public record UploadResponse(string result, string request_id, string data) : IResponseModel;
