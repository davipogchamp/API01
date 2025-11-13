using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Infra
{
    public class DbConnectionFactory(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("StringConexao");
    }

    public IDbConnection CreateConnection()
        {
            => new SqlConnection(_connectionString);
        }
    }
