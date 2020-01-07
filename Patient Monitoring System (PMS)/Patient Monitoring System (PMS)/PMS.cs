using Patient_Monitoring_System__PMS_.ConcreteClasses.Factories;
using Patient_Monitoring_System__PMS_.ConcreteClasses.HumanBodySystems;
using Patient_Monitoring_System__PMS_.ConcreteClasses.ObservablesAndObservers;
using Patient_Monitoring_System__PMS_.InterfacesAndAbstractClasses;
using System;

namespace Patient_Monitoring_System__PMS_
{
    class PMS
    {
        static void Main(string[] args)
        {
            PMS pmsSimulator = new PMS();
            AbstractSensorFactory sensorFactory = null;
            Console.Write("Please enter the name of the factory you want to use (GSF or PSF): ");
            string selectedFactory = Console.ReadLine();

            if (selectedFactory.Equals("GSF")){
                sensorFactory = GeneralSensorFactory.getInstance();
            }
            else if (selectedFactory.Equals("PSF"))
            {
                sensorFactory = PhillipsSensorFactory.getInstance();
            }
            pmsSimulator.simulate(sensorFactory);
        }

        void simulate(AbstractSensorFactory sensorFactory)
        {
            Observer pmsDisplay = new ReadingDisplay(); //Initializing the observer

            GroupHBS vbsGroup = (GroupHBS)sensorFactory.createVBS(50); //factory returns group here for subcategories
            HumanBodySystem rbs = sensorFactory.createRBS(20); //subcategory
            HumanBodySystem cbs = sensorFactory.createCBS(60); //subcategory
            vbsGroup.add(rbs); //adding subcategories
            vbsGroup.add(cbs); //adding subcategories

            HumanBodySystem dbs = sensorFactory.createDBS(10);
            HumanBodySystem nbs = sensorFactory.createNBS(30);
            HumanBodySystem ibs = sensorFactory.createIBS(60);

            GroupHBS hbsGroup = new GroupHBS(); //empty with default constructor
            hbsGroup.add(vbsGroup);
            hbsGroup.add(dbs);
            hbsGroup.add(nbs);
            hbsGroup.add(ibs);

            hbsGroup.registerObserver(pmsDisplay);

            simulate(hbsGroup);

            Console.WriteLine("The number of readings are " + HBScounter.getNumberOfReadings());
        }


        void simulate(HumanBodySystem hbs)
        {
            hbs.showReading();
        }
    }
}
