using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test1
{
    public class AccountControllerTestFixture
    {
        [
            Test,
             TestCase("abcd1234", false),
             TestCase("irf@uni-corvinus", false),
             TestCase("irf.uni-corvinus.hu", false),
             TestCase("irf@uni-corvinus.hu", true)

        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //ARRANGE
            var accountController = new AccountController();

            //ACT
            var result = accountController.ValidateEmail(email);

            //ASSERT
            Assert.AreEqual(result, expectedResult);

        }

        [
            Test,
            TestCase("abcd1234",false),
            TestCase("ABCD1234",false),
            TestCase("ABCDabcd", false),
            TestCase("ABbc12", false),
            TestCase("aBcD1234", true),
            TestCase("ABcde12345", true)

        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //ARRANGE
            var accountController = new AccountController();

            //ACT
            var result = accountController.ValidatePassword(password);

            //ASSERT
            Assert.AreEqual(expectedResult,result);

        }
        [
            Test,
             TestCase("irf@uni-corvinus.hu", "Abcd1234"),
             TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            //ARRANGE
            var accountController = new AccountController();

            //ACT
            var result = accountController.Register(email, password);

            //ASSERT
            Assert.AreEqual(email, result.Email);
            Assert.AreEqual(password, result.Password);
            Assert.AreNotEqual(Guid.Empty, result.ID);


        }
        [
            Test,
             TestCase("irf@uni-corvinus", "Abcd1234"),
             TestCase("irf.uni-corvinus.hu", "Abcd1234"),
             TestCase("irf@uni-corvinus.hu", "abcd1234"),
             TestCase("irf@uni-corvinus.hu", "ABCD1234"),
             TestCase("irf@uni-corvinus.hu", "abcdABCD"),
             TestCase("irf@uni-corvinus.hu", "Ab1234"),
       ]
        public void TestRegisterValidationException(string email, string password)
        {
            //ARRANGE
            var accountController = new AccountController();

            //ACT
            //ASSERT MERGED WITH ACT
            try
            {
                accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {

                Assert.IsInstanceOf<ValidationException>(ex);
            }
            

            
           


        }
    }
}
