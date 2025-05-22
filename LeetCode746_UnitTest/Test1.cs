namespace LeetCode746_UnitTest
{
    [TestClass]
    public sealed class Test1
    {
        private const int Expected = 17;
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new int[] { 5, 2, 3, 12, 20, 3, 1 };
            Staircase sc = new Staircase();
            var result = sc.MinCostClimbingStairs(arr);
            Assert.AreEqual(Expected, result);
        }
    }
}
