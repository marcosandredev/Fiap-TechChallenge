using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.Exceptions
{
    public class AlreadyExistsException : Exception
    {

        public AlreadyExistsException() : base(ExceptionMessage.Jogador_Already_Exists)
        {

        }

        public AlreadyExistsException(string message) : base(message)
        {

        }
    }

    public class AlreadyExistsExceptionClube : Exception
    {
        public AlreadyExistsExceptionClube() : base(ExceptionMessage.Clube_Already_Exists)
        {

        }

        public AlreadyExistsExceptionClube(string message) : base(message)
        {

        }
    }
}
