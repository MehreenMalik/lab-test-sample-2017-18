using NUnit.Framework;

public class TestStorageModel
{
	[Test]
	public void TestUnitsIsZero()
	{
		//arrange
		StorageModel sm = new StorageModel();
		int expectedResult = 0;

		//act
		int result = sm.GetUnits();

		//assert
		Assert.AreEqual(expectedResult, result);
	}

	[Test]
	public void TestIsNearlyFull()
	{
		//arrange
		StorageModel sm = new StorageModel();

		//act
		bool result = sm.IsNearlyFull();

		//assert
		Assert.False(result);
	}

	[Test]
	public void TestAfterDeliveryOfTen()
	{
		//arrange
		StorageModel sm = new StorageModel();
		int delivery = 10;
		int expectedResult = 10;

		//act
		bool deliverysuccess = sm.Deliver(delivery);
		int result = sm.GetUnits ();

		//assert
		Assert.True(deliverysuccess);
		Assert.AreEqual (expectedResult, result);
	}
}
