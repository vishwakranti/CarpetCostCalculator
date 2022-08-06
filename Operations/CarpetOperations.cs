namespace CarpetCostCalculator.Operations
{
    public static class CarpetOperations
    {

        public static decimal CalculateRoomArea(decimal length, decimal width)
        {
            return length * width;
        }

        public static decimal CalculateCarpetFinalCost(int costPerSqM, decimal areaOfCarpet, 
                                                        bool installation, bool underlay,       
                                  
                                                        decimal installationCost, decimal underlayCost)
        {
            decimal finalCost = costPerSqM * areaOfCarpet;
            if (installation)
                finalCost = finalCost + installationCost;

            if (underlay)
                finalCost = finalCost + underlayCost;
            return finalCost;
        }

        public static string CarpetQuote(decimal area, decimal finalCost)
        {
            return "Room Area " + area + "sqm $ " + finalCost;
        }
    }
}
