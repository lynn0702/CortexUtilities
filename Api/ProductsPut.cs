using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Data;

namespace Api;

public class CortexTraitsPut
{
    private readonly ICortexTraitData CortexTraitData;

    public CortexTraitsPut(ICortexTraitData CortexTraitData)
    {
        this.CortexTraitData = CortexTraitData;
    }

    [FunctionName("CortexTraitsPut")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "CortexTraits")] HttpRequest req,
        ILogger log)
    {
        var body = await new StreamReader(req.Body).ReadToEndAsync();
        var CortexTrait = JsonSerializer.Deserialize<CortexTrait>(body, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

        var updatedCortexTrait = await CortexTraitData.UpdateCortexTrait(CortexTrait);
        return new OkObjectResult(updatedCortexTrait);
    }
}
