using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.BLL;
using ThreeLayer.DAL;

namespace ThreeLayer.Common
{
    public static class DependencyResolver
    {
        static private ICatalog catalog_;
        static private IDiskLogic diskLogic;
        static public ICatalog Catalog_
        {
            get => catalog_ ?? (catalog_ = new Catalog());
        }
        static public IDiskLogic DiskLogic_
        {
            get => diskLogic ?? (diskLogic = new DiskLogic(Catalog_));
        }
    }
}
