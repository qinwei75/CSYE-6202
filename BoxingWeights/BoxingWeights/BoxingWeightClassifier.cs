namespace BoxingWeights
{
	public class BoxingWeightClassifier
	{
		public string ClassifyBoxingWeight(int weightInPounds)
		{
			string result = weightInPounds.ToString();
            // your solution/implementation should go in here
            result = "Heavyweight";
            if (weightInPounds >= 0 && weightInPounds <= 105)
            {
                result = "Strawweight" + " and " + result;
            }
            if (weightInPounds >= 106 && weightInPounds <= 108)
            {
                result = "JuniorFlyweight" + " and " + result;
            }
            if (weightInPounds >= 109 && weightInPounds <= 112)
            {
                result = "Flyweight" + " and " + result;
            }
            if (weightInPounds >= 113 && weightInPounds <= 115)
            {
                result = "Junior Bantamweight" + " and " + result;
            }
            if (weightInPounds >= 116 && weightInPounds <= 118)
            {
                result = "Bantamweight" + " and " + result;
            }
            if (weightInPounds >= 119 && weightInPounds <= 122)
            {
                result = "JuniorFeatherweight" + " and " + result;
            }
            if (weightInPounds >= 123 && weightInPounds <= 126)
            {
                result = "Featherweight" + " and " + result;
            }
            if (weightInPounds >= 127 && weightInPounds <= 130)
            {
                result = "JuniorLightweight" + " and " + result;
            }
            if (weightInPounds >= 131 && weightInPounds <= 135)
            {
                result = "Lightweight" + " and " + result;
            }
            if (weightInPounds >= 136 && weightInPounds <= 140)
            {
                result = "JuniorWelterweight" + " and " + result;
            }
            if (weightInPounds >= 141 && weightInPounds <= 147)
            {
                result = "WelterWeight" + " and " + result;
            }
            if (weightInPounds >= 148 && weightInPounds <= 154)
            {
                result = "JuniorMiddleweight" + " and " + result;
            }
            if (weightInPounds >= 155 && weightInPounds <= 160)
            {
                result = "Middleweight" + " and " + result;
            }
            if (weightInPounds >= 161 && weightInPounds <= 168)
            {
                result = "SuperMiddleweight" + " and " + result;
            }
            if (weightInPounds >= 168 && weightInPounds <= 175)
            {
                result = "LightHeavyweight" + " and " + result;
            }
            if (weightInPounds >= 176 && weightInPounds <= 200)
            {
                result = "Cruiserweight" + " and " + result;
            }

            return result;
		}
	}
}
