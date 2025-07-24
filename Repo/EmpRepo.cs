using AprilBatchMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilBatchMVCProject.Repo
{
    interface EmpRepo
    {
        void AddEmp(Emp e);

        List<Emp> FetchEmp();
    }
}
