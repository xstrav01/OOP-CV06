using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    abstract class GrObject3D : GrObject
    {
        public interface IFACE3D {
            double SpoctiPovrch();
            double SpoctiObjem();

        }

    }
}
