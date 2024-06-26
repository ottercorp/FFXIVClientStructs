using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Agent;

// Client::UI::Agent::ChatLog
//   Client::UI::Agent::AgentInterface
//     Component::GUI::AtkModuleInterface::AtkEventInterface
[Agent(AgentId.ChatLog)]
[StructLayout(LayoutKind.Explicit, Size = 0xB28)]
public unsafe partial struct AgentChatLog {
    [FieldOffset(0x00)] public AgentInterface AgentInterface;

    [FieldOffset(0x40)] public ChatChannel CurrentChannel;
    [FieldOffset(0x48)] public Utf8String ChannelLabel; // ie, "Say", "Party" that displays above the text input

    [FieldOffset(0x8A0)] public InventoryItem LinkedItem;

    [FieldOffset(0x8E0)] public Utf8String LinkedItemName;

    [FieldOffset(0x948)] public uint ContextItemId;

    [FieldOffset(0x958)] public ulong LinkedPartyFinderId;
    // [FieldOffset(0x960)] public byte LinkedPartyFinderUnkByte;

    [FieldOffset(0x968)] public Utf8String LinkedPartyFinderLeaderName;

    [FieldOffset(0x9D0)] public uint LinkedQuestId;

    [FieldOffset(0x9D8)] public Utf8String LinkedQuestName;
    [FieldOffset(0xA40)] public uint ContextStatusId; // also used for the <status> link?

    [MemberFunction("E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? 48 81 FF ?? ?? ?? ?? 75 20")]
    public partial bool InsertTextCommandParam(uint textParamId, bool unk);
}

// There are definitely more channels than just these, these were all the ones I could find quickly.
public enum ChatChannel {
    Say = 1,
    Party = 2,
    Alliance = 3,
}
