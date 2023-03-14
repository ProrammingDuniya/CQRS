using Application.Model;
using AutoMapper;
using Core;
using Infrastructure.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler
{
    /// <summary>
    /// CreateEmployeeCommand
    /// </summary>
    public record CreateEmployeeCommand(EmployeeCreateModel Model) : IRequest
    {
        /// <summary>
        /// GetAllProductsQueryHandler
        /// </summary>
        public record CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand>
        {
            private readonly IEmployeeCommandRepository _employeeCommandRepository;
            private readonly IMapper _mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetAllProductsQueryHandler"/> class.
            /// </summary>
            /// <param name="employeeQueryRepository">The employee query repository.</param>
            /// <param name="mapper">The mapper.</param>
            public CreateEmployeeCommandHandler(IEmployeeCommandRepository employeeCommandRepository, IMapper mapper)
            {
                _employeeCommandRepository = employeeCommandRepository;
                _mapper = mapper;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>
            /// Response from the request
            /// </returns>
            public async Task Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {
                var employee = _mapper.Map<Employee>(request.Model);

                await _employeeCommandRepository.CreateEmployee(employee);
            }
        }
    }
}
