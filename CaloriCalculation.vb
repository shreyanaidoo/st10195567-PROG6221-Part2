Imports NUnit.Framework

Namespace CalorieCalculationUnitTest

    Public Class CalorieCalculation

        {
    [Test]
    Public void TestCalorieCalculation()
    {
        // Arrange
        Recipe recipe = New recipes("Test Recipe");
        recipe.AddIngredient(New ingredients("Ingredient1", 100, "Group1"));
        recipe.AddIngredient(New ingredients("Ingredient2", 150, "Group2"));
        recipe.AddIngredient(New ingredients("Ingredient3", 60, "Group3"));

        // Act
        int CalorieCalculation = recipes.CalorieCalculation();

        // Assert
        Assert.AreEqual(310, totalCalories);
    }
}

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub Test1()
            Assert.Pass()
        End Sub



    End Class

End Namespace

// this method Is based on the tutorial from youtube
// "Getting started with unit testing in Visual Studio 2022"
//https://youtu.be/24ytq8JP2jI?si=0Z3-TBCX9pU9Pd3-