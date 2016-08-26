using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace TryMSpec.Test
{
    [Subject("Class1")]
    class When_testing_Class1 
    {
        Establish context = () =>
        {
            SUT = new Class1();  
        };

        class add0To0
        {
            Because of = () => Answer = Class1.Add(0, 0);

            It should_equal_to_0 = () => Answer.ShouldEqual(0);
        }

        class Add1To2
        {
            Because of1 = () => Answer = Class1.Add(1, 2);
            It should_equal_to_3 = () => Answer.ShouldEqual(3);
        }


        static Class1 SUT;
        static int Answer;
    }
}
