using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Mvc.Data
{
    public class DbInitializer
    {
        public static async Task SeedAsync(MysqlDbContext context)
        {
            try
            {
                if (true)
                {

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
