using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHub.Data.Models
{
    public static class ModelsValidationConstants
    {
        public static class Player
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 50;

            public const int DescriptionMinLength = 3;
            public const int DescriptionMaxLength = 200;
        }
    }
}
