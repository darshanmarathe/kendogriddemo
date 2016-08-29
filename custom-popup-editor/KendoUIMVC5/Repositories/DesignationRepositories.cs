
namespace KendoUIMVC5.Repositories
{
    using KendoUIMVC5.Models;
    using System.Collections.Generic;

    public class DesignationRepositories
    {
        public List<Designation> GetDesignation()
        {
            return new List<Designation>
            {
                new Designation { ID=1 , Name ="Jr Developer"  },
                new Designation { ID=2 , Name ="sr Developer"  },
                new Designation { ID=3 , Name ="Team Leader"  },
                new Designation { ID=4 , Name ="Assist Manger"  },
                new Designation { ID=5 , Name ="Sr Manager"  }

            };
        }
    }
}