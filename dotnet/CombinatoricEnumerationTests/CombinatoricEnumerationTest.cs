using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Combinatoric.Enumeration;

namespace Combinatoric.Enumeration.Test
{
    [TestClass]
    public class CombinatoricEnumerationTest
    {
        [DataTestMethod]
        [DataRow(5,1,5)]
        [DataRow(5,2,10)]
        [DataRow(5,5,1)]
        [DataRow(7,1,7)]
        [DataRow(7,3,35)]
        [DataRow(7,7,1)]
        [DataRow(9,1,9)]
        [DataRow(9,4,126)]
        [DataRow(9,9,1)]
        [DataRow(11,1,11)]
        [DataRow(11,5,462)]
        [DataRow(11,11,1)]
        [DataRow(15,1,15)]
        [DataRow(15,7,6435)]
        [DataRow(15,15,1)]
        public void CombinationTest(int n, int r, int nCr)
        {
            int[] items = Enumerable.Range(0, n).ToArray();
            var allCombinations = new HashSet<HashSet<int>>();

            foreach(List<int> combination in items.Combinations(r))
            {
                foreach(int item in combination)
                    Assert.IsTrue(items.Contains(item),$"Not an item in original pool of items: {item}");

                string combStr = string.Join(",", combination);
                var combSet = new HashSet<int>(combination);

                Assert.IsTrue(combination.Count() == r,$"Number of items in the combination is different that the expected: |{combStr}| != {r}");
                Assert.IsFalse(allCombinations.Contains(combSet),$"Duplicate combination created: {combStr}");
                allCombinations.Add(combSet);
            }
            int numElements = allCombinations.Count();
            Assert.IsTrue(numElements == nCr,$"Nmber of combination generated is not the same as the expected amount: {numElements} (actual) != {nCr} (expected)");
        }

        [DataTestMethod]
        [DataRow(5,1,5)]
        [DataRow(5,2,20)]
        [DataRow(5,5,120)]
        [DataRow(7,1,7)]
        [DataRow(7,3,210)]
        [DataRow(7,7,5040)]
        [DataRow(9,1,9)]
        [DataRow(9,4,3024)]
        [DataRow(9,9,362880)]
        [DataRow(11,1,11)]
        [DataRow(11,5,55440)]
        [DataRow(15,1,15)]
        [DataRow(15,5,360360)]
        public void PermutationTest(int n, int r, int nPr)
        {
            int[] items = Enumerable.Range(0, n).ToArray();
            var allPermutations = new HashSet<List<int>>();

            foreach(List<int> permutation in items.Permutations(r))
            {
                foreach(int item in permutation)
                    Assert.IsTrue(items.Contains(item),$"Not an item in original pool of items: {item}");

                string permStr = string.Join(",", permutation);

                Assert.IsTrue(permutation.Count() == r,$"Number of items in the permutation is different that the expected: |{permStr}| != {r}");
                Assert.IsFalse(allPermutations.Contains(permutation),$"Duplicate permutation created: {permStr}");
                allPermutations.Add(permutation);
            }
            int numElements = allPermutations.Count();
            Assert.IsTrue(numElements==nPr,$"Nmber of permutation generated is not the same as the expected amount: {numElements} (actual) != {nPr} (expected)");
        }
    }
}