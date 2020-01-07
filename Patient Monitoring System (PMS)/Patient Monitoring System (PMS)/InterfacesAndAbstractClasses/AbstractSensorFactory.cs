using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses
{
    public abstract class AbstractSensorFactory
    {
        public abstract HumanBodySystem createVBS(double value);
        public abstract HumanBodySystem createRBS(double value);
        public abstract HumanBodySystem createCBS(double value);
        public abstract HumanBodySystem createDBS(double value);
        public abstract HumanBodySystem createNBS(double value);
        public abstract HumanBodySystem createIBS(double value);
    }
}
