using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions;
using Microsoft.Extensions.DependencyInjection;
using APIPractice.infrastucture;

namespace APIPractice.infrastucture
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastucture(this IServiceCollection collection)
        {
            collection.AddDbContext<APIPracticeDBConttext>();
            return collection;
        }
    }
}
