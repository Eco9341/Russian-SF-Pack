using RussianSFPack.Helpers;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SPTarkov.Server.Core.Services;
using System.Reflection;
using WTTServerCommonLib.Helpers;
using WTTServerCommonLib.Models;
using WTTServerCommonLib.Services;
using Range = SemanticVersioning.Range;

namespace RussianSFPack;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.wtt.russiansfpack";
    public override string Name { get; init; } = "Russian-SF-Pack";
    public override string Author { get; init; } = "Eco";
    public override List<string>? Contributors { get; init; } = null;
    public override SemanticVersioning.Version Version { get; init; } = new(typeof(ModMetadata).Assembly.GetName().Version?.ToString(3));
    public override Range SptVersion { get; init; } = new("~4.0.13");
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, Range>? ModDependencies { get; init; } = new()
    {
        { "com.wtt.commonlib", new Range("~2.0.24") }
    };
    public override string? Url { get; init; }
    public override bool? IsBundleMod { get; init; } = true;
    public override string License { get; init; } = "MIT";
}


[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 2)]
public class RussianSFPack(
    WTTServerCommonLib.WTTServerCommonLib wttCommon,
    EcoQuestHelper ecoQuestHelper) : IOnLoad
{
    public async Task OnLoad()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly);
        await wttCommon.CustomAssortSchemeService.CreateCustomAssortSchemes(assembly);
        ecoQuestHelper.ModifyQuests();
        await Task.CompletedTask;
    }
}