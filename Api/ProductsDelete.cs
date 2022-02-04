using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Api;

public class CortexTraitsDelete
{
    private readonly ICortexTraitData CortexTraitData;

    public CortexTraitsDelete(ICortexTraitData CortexTraitData)
    {
        this.CortexTraitData = CortexTraitData;
    }

    [FunctionName("CortexTraitsDelete")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "CortexTraits/{CortexTraitId:int}")] HttpRequest req,
        string CortexTraitName,
        ILogger log)
    {
        var result = await CortexTraitData.DeleteCortexTrait(CortexTraitName);

        if (result)
        {
            return new OkResult();
        }
        else
        {
            return new BadRequestResult();
        }
    }
}
