using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.Models
{
    public class RegisterUserHandler : IRequestHandler<RegisterUser, bool>
    {
        

        public Task<bool> Handle(RegisterUser request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
