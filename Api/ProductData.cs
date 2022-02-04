using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;

namespace Api;

public interface ICortexTraitData
{
    Task<CortexTrait> AddCortexTrait(CortexTrait CortexTrait);
    Task<bool> DeleteCortexTrait(string name);
    Task<IEnumerable<CortexTrait>> GetCortexTraits();
    Task<CortexTrait> UpdateCortexTrait(CortexTrait CortexTrait);
}

public class CortexTraitData : ICortexTraitData
{
    private readonly List<CortexTrait> CortexTraits = new StaticData().GMCTraitList;

    public Task<CortexTrait> AddCortexTrait(CortexTrait CortexTrait)
    {
        CortexTraits.Add(CortexTrait);
        return Task.FromResult(CortexTrait);
    }

    public Task<CortexTrait> UpdateCortexTrait(CortexTrait CortexTrait)
    {
        var index = CortexTraits.FindIndex(p => p.Name == CortexTrait.Name);
        CortexTraits[index] = CortexTrait;
        return Task.FromResult(CortexTrait);
    }

    public Task<bool> DeleteCortexTrait(string name)
    {
        var index = CortexTraits.FindIndex(p => p.Name == name);
        CortexTraits.RemoveAt(index);
        return Task.FromResult(true);
    }

    public Task<IEnumerable<CortexTrait>> GetCortexTraits()
    {
        return Task.FromResult(CortexTraits.AsEnumerable());
    }
}
