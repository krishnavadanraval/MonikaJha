using Diamond;

namespace DiamondTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_with_Multiple_digits()
        {
            try 
            {
                DiamondClass.DiamondFunc("123");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                
            }
           
        }
        [TestMethod]
        public void TestMethod_with_capital_letter()
        {
            try
            {
                DiamondClass.DiamondFunc("A");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }
        [TestMethod]
        public void TestMethod_with_digit()
        {
            try
            {

                DiamondClass.DiamondFunc("1");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }
        [TestMethod]
        public void TestMethod_with_small_letter()
        {
            try
            {

                DiamondClass.DiamondFunc("a");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

            [TestMethod]
        public void TestMethod_with_multiple_letter()
            {
                try
                {

                    DiamondClass.DiamondFunc("abc");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                }

            }
        [TestMethod]
        public void TestMethod_with_special_char()
        {
            try
            {

                DiamondClass.DiamondFunc("@@");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }
        [TestMethod]
        public void TestMethod_with_alphanumric()
        {
            try
            {

                DiamondClass.DiamondFunc("a1b@");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }
    }
    
}