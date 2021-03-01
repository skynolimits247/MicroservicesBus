using MediatR;
using MicroservicesBus.Appointment.Application.Services;
using MicroservicesBus.Appointment.Data.Context;
using MicroservicesBus.Appointment.Data.Repository;
using MicroservicesBus.Appointment.Domain.CommandHandlers;
using MicroservicesBus.Appointment.Domain.Commands;
using MicroservicesBus.Appointment.Domain.Interfaces;
using MicroservicesBus.Domain.Core.Bus;
//using MicroservicesBus.Domain.Core.Commands;
using MicroservicesBus.Infra.Bus;
using MicroservicesBus.User.Application.Interfaces;
using MicroservicesBus.User.Application.Services;
using MicroservicesBus.User.Data.Context;
using MicroservicesBus.User.Data.Repository;
using MicroservicesBus.User.Domain.EventHandlers;
using MicroservicesBus.User.Domain.Events;
using MicroservicesBus.User.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesBus.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });
            //services.AddTransient<IEventBus, RabbitMQBus>();
            //subscriptions
            services.AddTransient<GetUserEventHandler>();

            //Domain userEvent
            services.AddTransient<IEventHandler<GetUserCreatedEvent>, GetUserEventHandler>();

            //Domain appointment commands
            services.AddTransient<IRequestHandler<CreateGetUserCommand, bool>, GetUserCommandHandler>();

            //Application Services
            services.AddTransient<IUserProfileService, UserProfileService>();
            services.AddTransient<IAppointmentService, AppointmentService>();

            //Data
            services.AddTransient<IUserProfileRepository, UserProfileRepository>();
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();

            services.AddTransient<UserProfileDbContext>();

            services.AddTransient<AppointmentDbContext>();
        }
    }
}
