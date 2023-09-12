﻿using AutoMapper.Extensions.ExpressionMapping;
using Iot.Core.DependencyInjection.Extensions;
using Iot.Core.EventStore.Configurations;
using Iot.Core.EventStore.Extensions.DependencyInjection;
using ShopFComputerBackEnd.Notification.Data;
using ShopFComputerBackEnd.Notification.Data.Repositories.Implements;
using ShopFComputerBackEnd.Notification.Data.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Iot.Core.EventBus.Configurations;
using Iot.Core.EventBus.Extensions.DependencyInjection;
using ShopFComputerBackEnd.Notification.Infrastructure.Handlers.IntegrationEvents;
using ShopFComputerBackEnd.Notification.Infrastructure.Handlers.Events;

namespace ShopFComputerBackEnd.Notification.Infrastructure.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, ConfigurationManager configuration)
        {
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var executingAssembly = Assembly.GetExecutingAssembly();
                var entryAssembly = Assembly.GetEntryAssembly();
                services.AddDependencies();
                services.AddAutoMapper(configuration =>
                {
                    configuration.AddExpressionMapping();
                }, executingAssembly, entryAssembly);
                services.AddMediatR(executingAssembly, entryAssembly);
                services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("Default")));
                services.AddEventStore(configuration.GetSection("EventStore").Get<EventStoreConfiguration>());
                services.AddEventBus(configuration.GetSection("EventBus").Get<EventBusConfiguration>());
                services.AddScoped<IHistoryRepository, HistoryRepository>();
                services.AddScoped<INotificationRepository, NotificationRepository>();
                services.AddScoped<INotificationTemplateRepository, NotificationTemplateRepository>();
                services.AddScoped<IDeviceRepository, DeviceRepository>();
                services.AddTransient<DeviceIntegrationEventHandler>();
                services.AddTransient<NotificationIntegrationEventHandler>();
                services.AddTransient<HistoryEventHandler>();

                return services;
            }
        }
    }
}