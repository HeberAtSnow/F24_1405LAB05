namespace Lab05Test;

 public class Lab5
    {
                [Fact]
        public void TestReverseStringABCDE()
        {
            string result = StudentProject.Program.ReverseString("ABCDE");
            Assert.Equal("EDCBA", result);
        }
                [Fact]
        public void TestReverseStringA()
        {
            string result = StudentProject.Program.ReverseString("A");
            Assert.Equal("A", result);
        }
                [Fact]
        public void TestReverseStringAtoZ()
        {
            string result = StudentProject.Program.ReverseString("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.Equal("ZYXWVUTSRQPONMLKJIHGFEDCBA", result);
        }
                [Fact]
        public void TestReverseStringAlphaNumeric()
        {
            string result = StudentProject.Program.ReverseString("ABCDEFGHIJKLM123456789NOPQRSTUVWXYZ");
            Assert.Equal("ZYXWVUTSRQPON987654321MLKJIHGFEDCBA", result);
        }
        
                [Fact]
        public void SortIntArray3579()
        {
            int[] result = StudentProject.Program.SortInts(new int[] {3,5,7,9} );
            Assert.Equal(3, result[0]);
            Assert.Equal(5, result[1]);
            Assert.Equal(7, result[2]);
            Assert.Equal(9, result[3]);
        }
        
                [Fact]
        public void SortIntArray9375()
        {
            int[] result = StudentProject.Program.SortInts(new int[] {9,3,7,5} );
            Assert.Equal(3, result[0]);
            Assert.Equal(5, result[1]);
            Assert.Equal(7, result[2]);
            Assert.Equal(9, result[3]);
        }
        
                [Fact]
        public void SortIntArray9753()
        {
            int[] result = StudentProject.Program.SortInts(new int[] {9,7,5,3} );
            Assert.Equal(3, result[0]);
            Assert.Equal(5, result[1]);
            Assert.Equal(7, result[2]);
            Assert.Equal(9, result[3]);
        }
                        [Fact]
        public void TestSortStringAZBCABBA()
        {
            string result = StudentProject.Program.SortString("AZBCABBA");
            Assert.Equal("AAABBBCZ", result);
        }
    }