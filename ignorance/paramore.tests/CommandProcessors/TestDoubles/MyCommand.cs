using System;
using Paramore.Services.Commands;
using Paramore.Services.Common;

namespace Paramore.Tests.CommandProcessors.TestDoubles
{
    internal class MyCommand : ICommand, IRequest
    {
        public MyCommand()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}