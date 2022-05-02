using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace Dencho
{
    public class EnterDungeon:BaseCommandModule
    {
        [Command("enter")]
        public async Task EnterDungeonCommand(CommandContext ctx, DiscordMember member)
        {
            await ctx.RespondAsync($"{member.Mention} Entered the scawwy Dungeon!");
        }
    }
}
