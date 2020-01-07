using Patient_Monitoring_System__PMS_.ConcreteClasses.HumanBodySystems;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;

namespace Patient_Monitoring_System__PMS_.ConcreteClasses.Factories
{
    public class PhillipsSensorFactory : AbstractSensorFactory
    {

        private static PhillipsSensorFactory uniqueInstance;
        private PhillipsSensorFactory() { }

        public static PhillipsSensorFactory getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new PhillipsSensorFactory();
            }

            return uniqueInstance;
        }

        public override HumanBodySystem createCBS(double value)
        {
            //You might want to set different boundaries for different sensors
            HumanBodySystem hbs = new CardiovasularBodySystem(value);
            hbs.lowerValue = 50;
            return new HBScounter(hbs);
        }

        public override HumanBodySystem createDBS(double value)
        {
            HumanBodySystem hbs = new DigestiveBodySystem(value);
            hbs.lowerValue = 0; //this wont appear in count
            return new HBScounter(hbs);
        }

        public override HumanBodySystem createIBS(double value)
        {
            return new HBScounter(new ImmuneBodySystem(value));
        }

        public override HumanBodySystem createNBS(double value)
        {
            return new HBScounter(new NervousBodySystem(value));
        }

        public override HumanBodySystem createRBS(double value)
        {
            return new HBScounter(new RespiratoryBodySystem(value));
        }

        public override HumanBodySystem createVBS(double value)
        {
            return new GroupHBS(new HBScounter(new VitalBodySystem(value)));
        }
    }
}
