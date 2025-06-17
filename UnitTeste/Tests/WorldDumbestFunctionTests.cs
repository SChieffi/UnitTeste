namespace UnitTeste.Tests
{
    public class WorldDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnsPikachuIfZero_ReturnsString()
        {
            try
            {
                //Arrange - go get your variables, whetever you need, you classes, you function
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();

                //Act - Execute this function
                string result = worldDumbest.ReturnsPikachuIfZero(num);

                //Assert - Whatever ever is returned is it what you want
                if (result == "PIKACHU")
                {
                    Console.WriteLine("PASSED: WorldDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
