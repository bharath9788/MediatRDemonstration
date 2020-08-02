using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRDemonstration.Models;
using System.Threading;

namespace MediatRDemonstration
{
    public class GetAllEmployeesQueries :IRequest<IEnumerable<Employee>>
    {


    }

    public class GetAllEmployeesQueriesHandler : IRequestHandler<GetAllEmployeesQueries, IEnumerable<Employee>>
    {
        public async Task<IEnumerable<Employee>> Handle(GetAllEmployeesQueries request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Employee { firstName = "Bharath", id = 1, lastName = "kumar"},
                new Employee { firstName = "Bharath_2", id = 3, lastName = "kumar_2"}
             };

        }
    }
}
