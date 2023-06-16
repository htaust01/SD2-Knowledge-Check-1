using System;
namespace Software2KnowledgeCheck1
{
	internal class Construction
	{
		public Construction()
		{
		}

        public void CreateApartment(Apartment apartment, City city)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();
            var permit = permitRepo.GetPermit();
            var zoningApproval = permitRepo.ZoningApproves();

            var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permit, zoningApproval);

            if (buildingWasMade)
            {
                city.Buildings.Add(apartment);
            }
        }

        public void CreateStructure<T>(T structure, City city) where T : Building
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();
            var permit = permitRepo.GetPermit();
            var zoningApproval = permitRepo.ZoningApproves();

            var buildingWasMade = ConstructBuilding<T>(materialsNeeded, permit, zoningApproval);

            if (buildingWasMade)
            {
                city.Buildings.Add(structure);
            }
        }

        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

