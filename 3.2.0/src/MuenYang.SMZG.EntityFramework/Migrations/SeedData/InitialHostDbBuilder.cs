using MuenYang.SMZG.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MuenYang.SMZG.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SMZGDbContext _context;

        public InitialHostDbBuilder(SMZGDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
