using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd",false),
            TestCase("irf@abc.com",true)
            
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
    }
}
