using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trulon.Exceptions
{
    using Microsoft.Xna.Framework.Content;

    public class ResourcesNotFoundException : Exception
    {
        public ResourcesNotFoundException(string message)
            : base(message)
        {

        }
    }
}
