﻿using ShopFComputerBackEnd.Notification.Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFComputerBackEnd.Notification.Infrastructure.Queries.Histories
{
    public class GetHistoryCollectionQuery : IRequest<IQueryable<HistoryDto>>
    {
    }
}
