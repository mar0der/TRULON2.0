namespace Trulon.Exceptions
{
    using System;

    public class ResourcesNotFoundException : Exception
    {
        public ResourcesNotFoundException(string message)
            : base(message)
        {
        }
    }
}
