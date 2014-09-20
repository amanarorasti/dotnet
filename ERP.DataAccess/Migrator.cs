using ERP.DataAccess.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataAccess
{
    public class Migrator : MigrateDatabaseToLatestVersion<Context,Configuration>
    {
    }
}
