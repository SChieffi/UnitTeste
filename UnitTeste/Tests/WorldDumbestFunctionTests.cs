namespace UnitTeste.Tests
{
    public class WorldDumbestFunctionTests
    {
        /// <summary>
        /// Executes a test for the <see cref="WorldDumbestFunction.ReturnsPikachuIfZero"/> method. Verifies that the
        /// method returns "PIKACHU" when the input is zero.
        /// </summary>
        /// <remarks>This method is intended to validate the behavior of <see
        /// cref="WorldDumbestFunction.ReturnsPikachuIfZero"/>  by providing a predefined input and checking the output
        /// against the expected result. It writes the test result to the console, indicating whether the test passed or
        /// failed.</remarks>
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
