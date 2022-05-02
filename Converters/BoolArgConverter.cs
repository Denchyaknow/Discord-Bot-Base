using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.CommandsNext.Converters;
using DSharpPlus.Entities;

namespace Dencho
{
    public class BoolArgConverter : IArgumentConverter<bool>
    {
        public Task<Optional<bool>> ConvertAsync(string value, CommandContext ctx)
        {
            if (bool.TryParse(value, out var boolean))
            {
                return Task.FromResult(Optional.FromValue(boolean));
            }

            switch (value.ToLower())
            {
                case "yes":
                case "y":
                case "t":
                    return Task.FromResult(Optional.FromValue(true));

                case "no":
                case "n":
                case "f":
                    return Task.FromResult(Optional.FromValue(false));

                default:
                    return Task.FromResult(Optional.FromNoValue<bool>());
            }
        }
    }
}
