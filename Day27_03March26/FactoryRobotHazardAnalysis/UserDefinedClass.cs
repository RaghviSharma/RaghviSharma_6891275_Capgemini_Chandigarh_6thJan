using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotHazardAnalysis
{
	public class RobotSafetyException : Exception
	{
		public RobotSafetyException(string message) : base(message)
		{
		}
	}
	public class UserDefinedClass
    {
		public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
		{
			if(armPrecision<0.0||armPrecision>1.0)
			{
				throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
			}
			if(workerDensity>20||workerDensity<1)
			{
				throw new RobotSafetyException("Error: Worker density must be 1-20");
			}
			if(machineryState!= "Worn"&& machineryState != "Faulty"&& machineryState !="Critical")
			{
				throw new RobotSafetyException("Error: Unsupported machinery state");
			}
			double machineRiskFactor = 0.0;
			if (machineryState == "Worn")
			{
				machineRiskFactor = 1.3;
			}
			else if (machineryState == "Faulty")
			{
				machineRiskFactor = 2.0;
			}
			else
			{
				machineRiskFactor = 3.0;
			}
				double riskFactor = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
			return riskFactor;
		}

	}
}
